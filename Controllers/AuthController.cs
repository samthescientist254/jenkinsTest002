namespace SmartApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using TransactionDataApiSettlement.Logic;
    using TransactionDataApiSettlement.Models;
    using TransactionDataApiSettlement.Models.TX;
    using TransactionDataApiSettlement.Models.XML;





    [Route("api/Tx")]
    public class AuthController : Controller
    {
        ApiCaller apiCaller = new ApiCaller();
        private readonly IOptions<MySetting> appSettings;
        private IOptions<Audience> _settings;
        private readonly TransactionDataApiSettlement.Models.PesaPointUATContext modelContext;
        TransactionDataApiSettlement.Models.TX.TokenResponse tokenResponse = new TransactionDataApiSettlement.Models.TX.TokenResponse();
        public AuthController(IOptions<Audience> settings, IOptions<MySetting> _appSettings, TransactionDataApiSettlement.Models.PesaPointUATContext context)
        {
            this._settings = settings;
            appSettings = _appSettings;
            modelContext = context;
        }
        [HttpPost("v2/cms/tranzaxis/transaction")]
        public async Task<IActionResult> PostAsyncTran([FromBody] CardDetailSearch value)
        {
            try
            {
                string res = await apiCaller.postAsyncjson(appSettings.Value.kadiurl + "/tx/transactions", JsonConvert.SerializeObject(value));
                Logic.WriteLog("Errorlog" + res);
                TxResponse transactions = JsonConvert.DeserializeObject<TxResponse>(res);

                /* var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(transactions.txTransaction);
                 List<TxTranRes> trans= JsonConvert.DeserializeObject<List<TxTranRes>>(jsonString);*/
                List<TxTranRes> tranRes = new List<TxTranRes>();
                foreach (var tran in transactions.txTransaction)
                {
                    var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(tran);
                    TxTranRes tra = JsonConvert.DeserializeObject<TxTranRes>(jsonString);
                    tra.accountNumber = tran.RID;
                    tra.postingDate = tran.POSTINGDAY;
                    tra.period = tran.TRANSACTIONDATE;
                    tra.RETRIEVALREFNUMBER = tran.RETRIEVALREFNUMBER;
                    tra.transactionReference = tran.SEQUENCENUMBER;
                    tranRes.Add(tra);
                }


                transactions.txTrans = tranRes.Where(u => Convert.ToDecimal(u.SOURCEAMOUNT) > 0).GroupBy(x => x.transactionReference).Select(x => x.FirstOrDefault()).ToList();
                transactions.txTransaction = null;
                // transactions.txTrans.GroupBy(x => x.transactionReference).Select(x => x.FirstOrDefault());


                return (IActionResult)Ok(transactions);
            }
            catch (Exception ex)
            {
                Logic.WriteLog("Errorlog" + ex.ToString());
            }
            return (IActionResult)Ok();
        }

        [HttpPost("v2/cms/tranzaxis/keyExchange")]
        public async Task<IActionResult> PostKey([FromBody] TransactionDataApiSettlement.Models.TX.User value)
        {
            var keys = modelContext.issuancekeys.Where(u => u.username == value.name && u.password == value.password).OrderByDescending(k => k.id);
            if (keys.Count() > 0)
            {
                TransactionDataApiSettlement.Models.issuancekeys issuancekeys = new TransactionDataApiSettlement.Models.issuancekeys();
                issuancekeys.instid = value.instid;
                issuancekeys.username = value.name;
                issuancekeys.password = value.password;

                KeyResponse keyResponse = new KeyResponse();
                keyResponse.key = Logic.generateKey();

                issuancekeys.aeskey = keyResponse.key;
                issuancekeys.datein = DateTime.Now;
                issuancekeys.active = 1;
                issuancekeys.publickeypath = keys.FirstOrDefault().publickeypath;
                modelContext.issuancekeys.Add(issuancekeys);
                modelContext.SaveChanges();


                keyResponse.responseCode = "00";
                keyResponse.responseMessage = "Success";
                keyResponse.expiryTime = DateTime.Now.AddDays(30).ToString();
                return (IActionResult)Ok(keyResponse);
            }
            else
            {
                KeyResponse keyResponse = new KeyResponse();
                keyResponse.responseCode = "01";
                keyResponse.responseMessage = "Key generation failed";
                return (IActionResult)Ok(keyResponse);
            }

        }

        [HttpPost("v2/cms/tranzaxis/files")]
        public object GetFiles([FromBody] TransactionDataApiSettlement.Models.TX.User value)
        {
            try
            {
                Logic.DownloadAll();
                tokenResponse.access_token = "Test";
                tokenResponse.expires_in = (int)TimeSpan.FromDays(365).TotalDays;

              

            }
            catch (Exception es)
            {
                Logic.WriteLog("Errorlog" + es.ToString());
            }



            return tokenResponse;
        }

        [HttpPost("v2/cms/tranzaxis/Auth")]
        public object Get([FromBody] TransactionDataApiSettlement.Models.TX.User user)
        {
            if (user.name == "TXUSERNG" && user.password == "HcH/soi4nHpwVXfNfYKxQkf0t7QmRYxqkGntbaic38M=")
            {

                var now = DateTime.UtcNow;

                var claims = new Claim[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,user.name),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, now.ToUniversalTime().ToString(), ClaimValueTypes.Integer64)
                };

                var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_settings.Value.Secret));
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = signingKey,
                    ValidateIssuer = true,
                    ValidIssuer = _settings.Value.Iss,
                    ValidateAudience = true,
                    ValidAudience = _settings.Value.Aud,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    RequireExpirationTime = true,

                };

                var jwt = new JwtSecurityToken(
                    issuer: _settings.Value.Iss,
                    audience: _settings.Value.Aud,
                    claims: claims,
                    notBefore: now,
                    expires: now.Add(TimeSpan.FromDays(365)),
                    signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
                );
                var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
                /*  var responseJson = new
                  {
                      access_token = encodedJwt,
                      expires_in = (int)TimeSpan.FromMinutes(2).TotalSeconds
                  };*/

                tokenResponse.access_token = encodedJwt;
                tokenResponse.expires_in = (int)TimeSpan.FromDays(365).TotalDays;


                return tokenResponse;
            }
            else
            {
                return tokenResponse;
            }
        }
    }

    public class Audience
    {
        public string Secret { get; set; }
        public string Iss { get; set; }
        public string Aud { get; set; }
    }
}
