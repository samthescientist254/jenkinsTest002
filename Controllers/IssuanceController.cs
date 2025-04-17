using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TransactionDataApiSettlement.Logic;
using TransactionDataApiSettlement.Models.XML;

namespace TransactionDataApiSettlement.Controllers
{
    [Route("api/")]
    [ApiController]
    public class IssuanceController : ControllerBase
    {
        private readonly IOptions<MySetting> appSettings;
        private readonly TransactionDataApiSettlement.Models.PesaPointUATContext modelContext;
        public IssuanceController(IOptions<MySetting> _appSettings, TransactionDataApiSettlement.Models.PesaPointUATContext context)
        {
            appSettings = _appSettings;
            modelContext = context;
        }

        [HttpPost("v2/cms/tranzaxis/application/create")]
        public async Task<IActionResult> B2cTransact([FromBody] RootRequest rootRequest)
        {
            IssuanceResponse issuanceResponse = new IssuanceResponse();
            try
            {
                CutomerValidation cutomerValidation = new CutomerValidation();
                string jspn = "{\"body\":{\"tran\":{\"request\":{\"specific\":{\"admin\":{\"subject\":{\"person\":{\"rid\":\"202412378\"}}}},\"initiatorRid\":\"Mapp\",\"processorInstName\":\"ProvidusBank\",\"lifePhase\":\"Single\",\"kind\":\"ReadSubject\",\"categoryText\":\"GetCustomerData\"}}}}";
                cutomerValidation = JsonConvert.DeserializeObject<CutomerValidation>(jspn);
                cutomerValidation.Header = new object();
                cutomerValidation.Body.Tran.Request.InitiatorRid = appSettings.Value.initiatorRid;
                cutomerValidation.Body.Tran.Request.CategoryText = appSettings.Value.categoryText;
                cutomerValidation.Body.Tran.Request.Kind = appSettings.Value.kind;
                cutomerValidation.Body.Tran.Request.LifePhase = appSettings.Value.lifePhase;

                string[] incomingnameinst = rootRequest.bridge.applications.application.FirstOrDefault().customer.productName.Split('_');


                string processorInstName = appSettings.Value.processorInstName;
                List<string> processorInstNames = processorInstName.Split(',').ToList();
                Dictionary<string, string> processorInstNamesdic = new Dictionary<string, string>();
                foreach (var nmt in processorInstNames)
                {
                    string[] xny = nmt.Split(':');
                    processorInstNamesdic.Add(xny[0], xny[1]);
                }
                cutomerValidation.Body.Tran.Request.ProcessorInstName = processorInstNamesdic[incomingnameinst[0]];

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
                ns.Add("tran", "http://schemas.tranzaxis.com/tran.wsdl");
                ns.Add("tran6", "http://schemas.tranzaxis.com/tran.xsd");
                ns.Add("sub", "http://schemas.tranzaxis.com/subjects-admin.xsd");
                List<string> custid = new List<string>();
                List<ReponseKey> responseKeys = new List<ReponseKey>();
                ReponseKey reponseKey = new ReponseKey();
                foreach (var customer in rootRequest.bridge.applications.application)
                {
                    cutomerValidation.Body.Tran.Request.Specific.Admin.Subject.Person.Rid = customer.customer.people.person.custIdNumber;
                    string xmlMessage1 = TransactionDataApiSettlement.Logic.MySerializer<CutomerValidation>.SerializeNameSpace(cutomerValidation, ns);

                    xmlMessage1 = Regex.Replace(xmlMessage1, @" xmlns:xs.*?"".*?""", "");
                    ApiCaller apiCaller = new ApiCaller();

                    string txurl = appSettings.Value.txurl;
                    List<string> txurls = txurl.Split(',').ToList();
                    Dictionary<string, string> txurlssdic = new Dictionary<string, string>();
                    foreach (var nmbt in txurls)
                    {
                        string[] xnyf = nmbt.Split(';');
                        txurlssdic.Add(xnyf[0], xnyf[1]);
                    }

                    string res = await apiCaller.postAsync(txurlssdic[incomingnameinst[0]], xmlMessage1);


                    if (res.Contains("subject was not found"))
                    {
                        reponseKey = new ReponseKey();
                        reponseKey.key = customer.customer.people.person.custIdNumber;
                        reponseKey.value = "00";
                        responseKeys.Add(reponseKey);

                    }
                    else
                    {
                        reponseKey = new ReponseKey();
                        reponseKey.key = customer.customer.people.person.custIdNumber;
                        reponseKey.value = "01";
                        responseKeys.Add(reponseKey);
                        custid.Add(customer.customer.people.person.custIdNumber);
                    }

                }
                foreach (var custr in custid)
                {
                    rootRequest.bridge.applications.application.RemoveAll(u => u.customer.people.person.custIdNumber == custr);
                }
                issuanceResponse.responseKeys = responseKeys;


            }
            catch (Exception ex)
            {
                issuanceResponse.responseCode = "96";
                issuanceResponse.responseMessage = "System Error";
                return (IActionResult)BadRequest(issuanceResponse);
            }

            string xmlMessage = TransactionDataApiSettlement.Logic.MySerializer<Bridge>.Serialize(rootRequest.bridge);

            xmlMessage = Regex.Replace(xmlMessage, @" xmlns:xs.*?"".*?""", "");

            notifyparams notifyparams = new notifyparams();
            notifyparams.smtpclient = appSettings.Value.smtpclient;
            notifyparams.smtpport = appSettings.Value.smtpclient;
            notifyparams.netUsr = appSettings.Value.smtpclient;
            notifyparams.netPas = appSettings.Value.smtpclient;
            notifyparams.mailFrom = appSettings.Value.smtpclient;



            try
            {
                if (rootRequest.bridge.applications.application.Count() > 0)
                {
                    string name = appSettings.Value.filename;
                    List<string> names = name.Split(',').ToList();
                    Dictionary<string, string> namesdic = new Dictionary<string, string>();
                    foreach (var nm in names)
                    {
                        string[] ny = nm.Split(':');
                        namesdic.Add(ny[0], ny[1]);
                    }

                    string remotepath = appSettings.Value.remotepath;
                    List<string> remotepaths = remotepath.Split(',').ToList();
                    Dictionary<string, string> remotedic = new Dictionary<string, string>();
                    foreach (var nmm in remotepaths)
                    {
                        string[] nyy = nmm.Split(':');
                        remotedic.Add(nyy[0], nyy[1]);
                    }

                    string[] incomingname = rootRequest.bridge.applications.application.FirstOrDefault().customer.productName.Split('_');


                    string file = appSettings.Value.FilesPath + namesdic[incomingname[0]] + rootRequest.bridge.applications.application.Count() + "_" + rootRequest.bridge.applications.application.FirstOrDefault().customer.productName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xml";
                    System.IO.File.WriteAllText(file, xmlMessage);
                    SftpClient client = Logic.Logic.connectSftp("", false);
                    Logic.Logic.copySSHFiles(client, file, remotedic[incomingname[0]], false);
                   
                    client.Disconnect();
                    issuanceResponse.responseCode = "00";
                    issuanceResponse.responseMessage = "Success";

                    List<string> fils = new List<string>();
                    fils.Add(file);

                    try
                    {
                        Logic.Logic.byEmail(notifyparams, "API CARD ORDER FILES", appSettings.Value.recipients, Logic.Logic.getFileUploadEmail(fils, appSettings.Value.emailTemplate, incomingname[0]));
                    }
                    catch (Exception ex) {
                        Logic.Logic.WriteLog(ex.ToString());
                    }



                }
                else
                {
                    issuanceResponse.responseCode = "01";
                    issuanceResponse.responseMessage = "Customer id's exists";
                }
            }
            catch (Exception ex)
            {
                issuanceResponse.responseCode = "96";
                issuanceResponse.responseMessage = "System Error";
                Logic.Logic.WriteLog(ex.ToString());
                return (IActionResult)BadRequest(issuanceResponse);
            }
            return (IActionResult)Ok(issuanceResponse);
        }

        [HttpPost("v2/cms/tranzaxis/application/create/enc")]
        public async Task<IActionResult> createAccount([FromBody] EncryptedRequest request)
        {
        // string enmm = Logic.Logic.AESEncrypyt("{\n     \"bridge\":{\n        \"applications\": {\n            \"application\": [\n                {\n                    \"customer\": {\n                        \"accounts\": {\n                            \"account\": {\n                                \"riskDomains\": {\n                                    \"riskDomain\": {\n                                        \"groupNumber\": \"1\",\n                                        \"authCurrency\": \"566\",\n                                        \"authLimit\": \"10000\"\n                                    }\n                                },\n                                \"cards\": {\n                                    \"card\": {\n                                        \"extensions\": {\n                                            \"extension\": {\n                                                \"fieldNo\": \"10000\",\n                                                \"value\": \"012\"\n                                            }\n                                        },\n                                        \"embName\": \"INDONESIA\",\n                                        \"templateCode\": \"PCCBC1\",\n                                        \"country\": \"566\",\n                                        \"primaryCard\": \"1\",\n                                        \"auth1TrxnLimit\": \"20000\"\n                                    }\n                                },\n                                \"templateCode\": \"PCCBA\",\n                                \"creditLimit\": \"1000\",\n                                \"bankAccount\": \"0100000000010\",\n                                \"bankSortCode\": \"111-015\",\n                                \"bankBranch\": \"012\",\n                                \"bankName\": \"FIRST CITY MONUMENT\",\n                                \"bankDdEnabled\": \"1\",\n                                \"bankDdAmount\": \"0\",\n                                \"bankDdPercentage\": \"10\",\n                                \"bankDdCombination\": \"1\",\n                                \"bankAccCountry\": \"566\",\n                                \"minPayAmount\": \"0\",\n                                \"minPayPercentage\": \"10\",\n                                \"minPayCombination\": \"1\",\n                                \"stmtTriggerBal\": \"0\",\n                                \"stmtMailOption\": \"1\"\n                            }\n                        },\n                        \"people\": {\n                            \"person\": {\n                                \"addresses\": {\n                                    \"address\": {\n                                        \"addressType\": \"1111\",\n                                        \"location\": \"work\",\n                                        \"address1\": \"PLOT NO MAGAR COURT\",\n                                        \"address2\": \"00100\",\n                                        \"address3\": \"45 AWOYOKUN STREET ILUPEJU\",\n                                        \"city\": \"ILUPEJU\",\n                                        \"country\": \"566\",\n                                        \"mobile\": \"2347000000002\",\n                                        \"email\": \"fcmb@cardcentre.ng\"\n                                    }\n                                },\n                                \"relationship\": \"OWNER\",\n                                \"title\": \"MS\",\n                                \"lastName\": \"INDONESIA\",\n                                \"midName\": \"WORLD\",\n                                \"firstName\": \"INDONESIA\",\n                                \"motherName\": \"FLAGSHIP\",\n                                \"organization\": \"SHELL NIGERIA\",\n                                \"dob\": \"1995-09-23\",\n                                \"sex\": \"F\",\n                                \"ssnumber\": \"2880231228874\",\n                                \"custIdNumber\": \"2880231228874\"\n                            }\n                        },\n                        \"productName\": \"FCMB_VRDC_Credit_Cash_Backed_Classic\",\n                        \"templateCode\": \"FCMBC\",\n                        \"maxAggcl\": \"1000\"\n                    }\n                },\n                {\n                    \"customer\": {\n                        \"accounts\": {\n                            \"account\": {\n                                \"riskDomains\": {\n                                    \"riskDomain\": {\n                                        \"groupNumber\": \"1\",\n                                        \"authCurrency\": \"566\",\n                                        \"authLimit\": \"10000\"\n                                    }\n                                },\n                                \"cards\": {\n                                    \"card\": {\n                                        \"extensions\": {\n                                            \"extension\": {\n                                                \"fieldNo\": \"10000\",\n                                                \"value\": \"012\"\n                                            }\n                                        },\n                                        \"embName\": \"MALAYSIA\",\n                                        \"templateCode\": \"PGCBC1\",\n                                        \"country\": \"566\",\n                                        \"primaryCard\": \"1\",\n                                        \"auth1TrxnLimit\": \"2000000\"\n                                    }\n                                },\n                                \"templateCode\": \"PCCBA\",\n                                \"creditLimit\": \"1000\",\n                                \"bankAccount\": \"0100000000010\",\n                                \"bankSortCode\": \"111-015\",\n                                \"bankBranch\": \"012\",\n                                \"bankName\": \"FIRST CITY MONUMENT\",\n                                \"bankDdEnabled\": \"1\",\n                                \"bankDdAmount\": \"10000\",\n                                \"bankDdPercentage\": \"10\",\n                                \"bankDdCombination\": \"1\",\n                                \"bankAccCountry\": \"566\",\n                                \"minPayAmount\": \"0\",\n                                \"minPayPercentage\": \"10\",\n                                \"minPayCombination\": \"1\",\n                                \"stmtTriggerBal\": \"0\",\n                                \"stmtMailOption\": \"1\"\n                            }\n                        },\n                        \"people\": {\n                            \"person\": {\n                                \"addresses\": {\n                                    \"address\": {\n                                        \"addressType\": \"1111\",\n                                        \"location\": \"work\",\n                                        \"address1\": \"PLOT NO MAGAR COURT\",\n                                        \"address2\": \"00100\",\n                                        \"address3\": \"45 AWOYOKUN STREET ILUPEJU\",\n                                        \"city\": \"ILUPEJU\",\n                                        \"country\": \"566\",\n                                        \"mobile\": \"2347000000002\",\n                                        \"email\": \"fcmb@cardcentre.ng\"\n                                    }\n                                },\n                                \"relationship\": \"OWNER\",\n                                \"title\": \"MR\",\n                                \"lastName\": \"MALAYSIA\",\n                                \"midName\": \"TEST\",\n                                \"firstName\": \"MALAYSIA\",\n                                \"motherName\": \"FLAGSHIP\",\n                                \"organization\": \"SHELL NIGERIA\",\n                                \"dob\": \"1995-09-23\",\n                                \"sex\": \"F\",\n                                \"ssnumber\": \"2088231227B7775\",\n                                \"custIdNumber\": \"2088231227B7775\"\n                            }\n                        },\n                        \"productName\": \"FCMB_VRDC_Credit_Cash_Backed_Gold\",\n                        \"templateCode\": \"FCMBG\",\n                        \"maxAggcl\": \"1000\"\n                    }\n                }\n            ]\n     }   }}", Convert.FromBase64String("9x5uCfpqPYeweNsBcDCY3EnovfxQ1kc7ApPAgDPNEZo="));
          // request.enc = enmm;
           //request.signature = Logic.Logic.SignData(request.enc, Logic.Logic.GetRsaParameters(System.IO.File.ReadAllText(@"D:\Downloads\vcc_v2(1)\private.key")));
            IssuanceResponse issuanceResponse = new IssuanceResponse();
            try
            {
                var keys = modelContext.issuancekeys.Where(u => u.instid == request.instid).OrderByDescending(k => k.id).FirstOrDefault();

                if (!Logic.Logic.VerifySignature(request.enc, request.signature, keys.publickeypath))
                {
                    issuanceResponse.responseCode = "02";
                    issuanceResponse.responseMessage = "Invalid Signature";
                    return (IActionResult)BadRequest(issuanceResponse);
                }
                RootRequest rootRequest = new RootRequest();
                try
                {

                    string enm = Logic.Logic.AESDecrypt(request.enc, Convert.FromBase64String(keys.aeskey));
                    rootRequest = JsonConvert.DeserializeObject<RootRequest>(enm);
                }
                catch (Exception ex)
                {
                    issuanceResponse.responseCode = "03";
                    issuanceResponse.responseMessage = "Invalid Decryption key";
                    return (IActionResult)BadRequest(issuanceResponse);
                }
                try
                {
                    CutomerValidation cutomerValidation = new CutomerValidation();
                    string jspn = "{\"body\":{\"tran\":{\"request\":{\"specific\":{\"admin\":{\"subject\":{\"person\":{\"rid\":\"202412378\"}}}},\"initiatorRid\":\"Mapp\",\"processorInstName\":\"ProvidusBank\",\"lifePhase\":\"Single\",\"kind\":\"ReadSubject\",\"categoryText\":\"GetCustomerData\"}}}}";
                    cutomerValidation = JsonConvert.DeserializeObject<CutomerValidation>(jspn);
                    cutomerValidation.Header = new object();
                    cutomerValidation.Body.Tran.Request.InitiatorRid = appSettings.Value.initiatorRid;
                    cutomerValidation.Body.Tran.Request.CategoryText = appSettings.Value.categoryText;
                    cutomerValidation.Body.Tran.Request.Kind = appSettings.Value.kind;
                    cutomerValidation.Body.Tran.Request.LifePhase = appSettings.Value.lifePhase;

                    string[] incomingnameinst = rootRequest.bridge.applications.application.FirstOrDefault().customer.productName.Split('_');


                    string processorInstName = appSettings.Value.processorInstName;
                    List<string> processorInstNames = processorInstName.Split(',').ToList();
                    Dictionary<string, string> processorInstNamesdic = new Dictionary<string, string>();
                    foreach (var nmt in processorInstNames)
                    {
                        string[] xny = nmt.Split(':');
                        processorInstNamesdic.Add(xny[0], xny[1]);
                    }
                    cutomerValidation.Body.Tran.Request.ProcessorInstName = processorInstNamesdic[incomingnameinst[0]];

                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    ns.Add("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
                    ns.Add("tran", "http://schemas.tranzaxis.com/tran.wsdl");
                    ns.Add("tran6", "http://schemas.tranzaxis.com/tran.xsd");
                    ns.Add("sub", "http://schemas.tranzaxis.com/subjects-admin.xsd");
                    List<string> custid = new List<string>();
                    List<ReponseKey> responseKeys = new List<ReponseKey>();
                    ReponseKey reponseKey = new ReponseKey();
                    foreach (var customer in rootRequest.bridge.applications.application)
                    {
                        cutomerValidation.Body.Tran.Request.Specific.Admin.Subject.Person.Rid = customer.customer.people.person.custIdNumber;
                        string xmlMessage1 = TransactionDataApiSettlement.Logic.MySerializer<CutomerValidation>.SerializeNameSpace(cutomerValidation, ns);

                        xmlMessage1 = Regex.Replace(xmlMessage1, @" xmlns:xs.*?"".*?""", "");
                        ApiCaller apiCaller = new ApiCaller();

                        string txurl = appSettings.Value.txurl;
                        List<string> txurls = txurl.Split(',').ToList();
                        Dictionary<string, string> txurlssdic = new Dictionary<string, string>();
                        foreach (var nmbt in txurls)
                        {
                            string[] xnyf = nmbt.Split(';');
                            txurlssdic.Add(xnyf[0], xnyf[1]);
                        }

                        string res = await apiCaller.postAsync(txurlssdic[incomingnameinst[0]], xmlMessage1);


                        if (res.Contains("subject was not found"))
                        {
                            reponseKey = new ReponseKey();
                            reponseKey.key = customer.customer.people.person.custIdNumber;
                            reponseKey.value = "00";
                            responseKeys.Add(reponseKey);

                        }
                        else
                        {
                            reponseKey = new ReponseKey();
                            reponseKey.key = customer.customer.people.person.custIdNumber;
                            reponseKey.value = "01";
                            responseKeys.Add(reponseKey);
                            custid.Add(customer.customer.people.person.custIdNumber);
                        }

                    }
                    foreach (var custr in custid)
                    {
                        rootRequest.bridge.applications.application.RemoveAll(u => u.customer.people.person.custIdNumber == custr);
                    }
                    issuanceResponse.responseKeys = responseKeys;
                }
                catch (Exception ex)
                {
                    issuanceResponse.responseCode = "01";
                    issuanceResponse.responseMessage = ex.ToString();
                    return (IActionResult)Ok(issuanceResponse);
                }

                string xmlMessage = TransactionDataApiSettlement.Logic.MySerializer<Bridge>.Serialize(rootRequest.bridge);

                xmlMessage = Regex.Replace(xmlMessage, @" xmlns:xs.*?"".*?""", "");


                try
                {
                    if (rootRequest.bridge.applications.application.Count() > 0)
                    {
                        string name = appSettings.Value.filename;
                        List<string> names = name.Split(',').ToList();
                        Dictionary<string, string> namesdic = new Dictionary<string, string>();
                        foreach (var nm in names)
                        {
                            string[] ny = nm.Split(':');
                            namesdic.Add(ny[0], ny[1]);
                        }

                        string remotepath = appSettings.Value.remotepath;
                        List<string> remotepaths = remotepath.Split(',').ToList();
                        Dictionary<string, string> remotedic = new Dictionary<string, string>();
                        foreach (var nmm in remotepaths)
                        {
                            string[] nyy = nmm.Split(':');
                            remotedic.Add(nyy[0], nyy[1]);
                        }

                        string[] incomingname = rootRequest.bridge.applications.application.FirstOrDefault().customer.productName.Split('_');
                        string fname = namesdic[incomingname[0]] + rootRequest.bridge.applications.application.Count() + "_" + rootRequest.bridge.applications.application.FirstOrDefault().customer.productName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xml";

                        string file = appSettings.Value.FilesPath + fname;
                        System.IO.File.WriteAllText(file, xmlMessage);
                        SftpClient client = Logic.Logic.connectSftp("", false);
                        Logic.Logic.copySSHFiles(client, file, remotedic[incomingname[0]], false);

                        // ArrayList fnames = client.getf(remotedic[incomingname[0]]);
                        int milliseconds = 10000;
                        Thread.Sleep(milliseconds);
                        //client.Disconnect();
                        client = Logic.Logic.connectSftp("", false);
                        var files = Logic.Logic.GetFiles(remotedic[incomingname[0]].Substring(0, remotedic[incomingname[0]].Length - 6) + "/" + "backup", client);
                        //  var files3 = Logic.Logic.GetFiles(remotedic[incomingname[0]].Substring(0, remotedic[incomingname[0]].Length - 6) + "/" + "backup", client);
                        //client.Disconnect();


                        if (files.Contains(fname))
                        {
                            issuanceResponse.responseCode = "00";
                            issuanceResponse.responseMessage = "Success";
                        }
                        else
                        {
                            issuanceResponse.responseCode = "96";
                            issuanceResponse.responseMessage = "System Error";
                        }

                    }
                    else
                    {
                        issuanceResponse.responseCode = "01";
                        issuanceResponse.responseMessage = "Customer id's exists";
                    }
                }
                catch (Exception ex)
                {
                    issuanceResponse.responseCode = "96";
                    issuanceResponse.responseMessage = "System Error";
                    Logic.Logic.WriteLog(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                issuanceResponse.responseCode = "96";
                issuanceResponse.responseMessage = "System Error";
                return (IActionResult)BadRequest(issuanceResponse);
            }

            return (IActionResult)Ok(issuanceResponse);
        }


        [HttpPost("v2/cms/tranzaxis/customer/validation")]
        public async Task<IActionResult> Validate([FromBody] CutomerValidation rootRequest)
        {

            rootRequest.Header = new object();
            rootRequest.Body.Tran.Request.InitiatorRid = appSettings.Value.initiatorRid;
            rootRequest.Body.Tran.Request.CategoryText = appSettings.Value.categoryText;
            rootRequest.Body.Tran.Request.Kind = appSettings.Value.kind;
            rootRequest.Body.Tran.Request.LifePhase = appSettings.Value.lifePhase;
            rootRequest.Body.Tran.Request.ProcessorInstName = appSettings.Value.processorInstName;

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
            ns.Add("tran", "http://schemas.tranzaxis.com/tran.wsdl");
            ns.Add("tran6", "http://schemas.tranzaxis.com/tran.xsd");
            ns.Add("sub", "http://schemas.tranzaxis.com/subjects-admin.xsd");

            string xmlMessage = TransactionDataApiSettlement.Logic.MySerializer<CutomerValidation>.SerializeNameSpace(rootRequest, ns);

            xmlMessage = Regex.Replace(xmlMessage, @" xmlns:xs.*?"".*?""", "");

            IssuanceResponse issuanceResponse = new IssuanceResponse();

            try
            {
                ApiCaller apiCaller = new ApiCaller();

                string res = await apiCaller.postAsync("http://172.16.112.113:10043", xmlMessage);

                if (res.Contains("subject was not found"))
                {
                    issuanceResponse.responseCode = "00";
                    issuanceResponse.responseMessage = "Success";
                }
                else
                {
                    issuanceResponse.responseCode = "01";
                    issuanceResponse.responseMessage = "Customer Exists";

                }


            }
            catch (Exception ex)
            {
                issuanceResponse.responseCode = "01";
                issuanceResponse.responseMessage = ex.ToString();
            }
            return (IActionResult)Ok(issuanceResponse);
        }

    }
}
