using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionDataApiSettlement.ArbiterModels;
using TransactionDataApiSettlement.Models;
using TransactionDataApiSettlement.Queries;


namespace TransactionDataApiSettlement.Controllers
{
    [Route("/arbiter/api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IMediator _mediator;

        private readonly PesaPointUATContext modelContext;

        public TransactionController(IMediator mediator, PesaPointUATContext context)
        {

            _mediator = mediator;
            modelContext = context;
        }

        [HttpGet("transactionapi/ret/list/")]
        public IEnumerable<ShclogNonPpt> Get()
        {
            GetAllShcLogQuery branchesQuery = new GetAllShcLogQuery();
            var result = _mediator.Send(branchesQuery);
            return result.Result;
        }
        [HttpGet("{START_DATE}/{END_DATE}/{ACCOUNT}/{PAN}/{STAN}/{RRN}/{TERMINAL}")]
        public async Task<IActionResult> GetAccount(string START_DATE, string END_DATE, string ACCOUNT, string PAN, string STAN, string RRN, string TERMINAL)
        {

            DateTime sdate = DateTime.ParseExact(START_DATE, "dd-MM-yyyy", null);
            DateTime edate = DateTime.ParseExact(END_DATE, "dd-MM-yyyy", null);
            string pan = String.IsNullOrWhiteSpace(PAN) ? "" : "and pan like '%" + PAN + "%'";
            string stan = String.IsNullOrWhiteSpace(STAN) ? "" : "and Origtrace like '%" + STAN + "%'";
            string tem = String.IsNullOrWhiteSpace(TERMINAL) ? "" : "and termid like '%" + TERMINAL + "%'";
            string rrn = String.IsNullOrWhiteSpace(RRN) ? "" : "and sms_id like '%" + RRN + "%'";
            string acc = String.IsNullOrWhiteSpace(ACCOUNT) ? "" : "and acctnum like '%" + ACCOUNT + "%'";
            var drtt = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + "16:00:00";

            // var drtt = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + " " + "16:00:00";




            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@sdate",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = sdate
                        },
                         new SqlParameter() {
                            ParameterName = "@edate",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = edate
                        },
                          new SqlParameter() {
                            ParameterName = "@bdate",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = drtt
                        }
            };

            Logic.Logic.WriteLog("querry");


            var myTableResults =
                 this.modelContext.ShclogNonPpt.FromSqlRaw("[dbo].[sp_GetTransWithDates] @sdate, @edate,@bdate", param).ToList();

            if (!String.IsNullOrWhiteSpace(PAN))
            {
                myTableResults = myTableResults.Where(u => u.Pan == PAN).ToList();
            }
            if (!String.IsNullOrWhiteSpace(STAN))
            {
                myTableResults = myTableResults.Where(u => u.Origtrace == int.Parse(STAN)).ToList();
            }
            if (!String.IsNullOrWhiteSpace(TERMINAL))
            {
                myTableResults = myTableResults.Where(u => u.Termid == TERMINAL).ToList();
            }

            if (!String.IsNullOrWhiteSpace(RRN))
            {
                myTableResults = myTableResults.Where(u => u.Refnum == RRN).ToList();
            }
            if (!String.IsNullOrWhiteSpace(ACCOUNT))
            {
                myTableResults = myTableResults.Where(u => u.Acctnum == ACCOUNT).ToList();
            }


            /*var result = await _mediator.Send(querry);*/
            var result = myTableResults;
            return result != null ? (IActionResult)Ok(result) : NotFound();
        }

        [HttpGet("transactionapi/retrieve/list/")]
        public async Task<IActionResult> GetAccount1([FromQuery(Name = "start_date")] string START_DATE, [FromQuery(Name = "end_date")] string END_DATE, [FromQuery(Name = "account")] string ACCOUNT, [FromQuery(Name = "pan")] string PAN, [FromQuery(Name = "stan")] string STAN,
            [FromQuery(Name = "rrn")] string RRN, [FromQuery(Name = "terminal")] string TERMINAL)
        {


            Logic.Logic.WriteLog("start_date");
            Logic.Logic.WriteLog(START_DATE);

            Logic.Logic.WriteLog("END_DATE");
            Logic.Logic.WriteLog(END_DATE);


            Logic.Logic.WriteLog("STAN");
            Logic.Logic.WriteLog(STAN);


            Logic.Logic.WriteLog("RRN");
            Logic.Logic.WriteLog(RRN);

            string issuer = "";
            string acquirer = "";
            var institutions =
           this.modelContext.Institutions.FromSqlRaw(
            "[dbo].[sp_SelectAllinstitutions]").ToList();
            var bins_ppt =
           this.modelContext.PptBins.FromSqlRaw(
            "[dbo].[sp_SelectAllppt_bins]").ToList();

            DateTime sdate = DateTime.ParseExact(START_DATE, "dd-MM-yyyy", null);
            DateTime edate = DateTime.ParseExact(END_DATE, "dd-MM-yyyy", null);

            string stdate = sdate.ToString("MM-dd-yyyy HH:mm:ss");
            string etdate = edate.ToString("MM-dd-yyyy HH:mm:ss");
            /* string pan = String.IsNullOrWhiteSpace(PAN) ? "" : "and pan like '%" + PAN + "%'";
             string stan = String.IsNullOrWhiteSpace(STAN) ? "" : "and Origtrace like '%" + STAN + "%'";
             string tem = String.IsNullOrWhiteSpace(TERMINAL) ? "" : "and termid like '%" + TERMINAL + "%'";
             string rrn = String.IsNullOrWhiteSpace(RRN) ? "" : "and Refnum like '%" + RRN + "%'";
             string acc = String.IsNullOrWhiteSpace(ACCOUNT) ? "" : "and acctnum like '%" + ACCOUNT + "%'";
 */

            var drtt = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + " " + "16:00:00";




            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@sdate",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = stdate
                        },
                         new SqlParameter() {
                            ParameterName = "@edate",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = etdate
                        },
                          new SqlParameter() {
                            ParameterName = "@bdate",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = drtt
                        }
            };

            Logic.Logic.WriteLog("querry");


            var myTableResults =
                 this.modelContext.ShclogNonPpt.FromSqlRaw("[dbo].[sp_GetTransWithDates] @sdate, @edate,@bdate", param).ToList();

            if (!String.IsNullOrWhiteSpace(PAN))
            {
                myTableResults = myTableResults.Where(u => Logic.Logic.maskCardNumber(u.Pan, "######******####").Trim() == PAN.Trim()).ToList();
            }
            if (!String.IsNullOrWhiteSpace(STAN))
            {
                myTableResults = myTableResults.Where(u => u.Origtrace == int.Parse(STAN)).ToList();
            }
            if (!String.IsNullOrWhiteSpace(TERMINAL))
            {
                myTableResults = myTableResults.Where(u => u.Termid == TERMINAL).ToList();
            }

            if (!String.IsNullOrWhiteSpace(RRN))
            {
                myTableResults = myTableResults.Where(u => u.Refnum == RRN).ToList();
            }
            if (!String.IsNullOrWhiteSpace(ACCOUNT))
            {
                myTableResults = myTableResults.Where(u => u.Acctnum == ACCOUNT).ToList();
            }


            var result = myTableResults.Where(i => i.Amount > 0).ToList();
            List<Transaction> transactions = new List<Transaction>();
            Transaction transaction = new Transaction();
            foreach (var xyz in result)
            {
                try
                {
                    issuer = "";
                    acquirer = "";

                    var bin = bins_ppt.Where(u => u.Bin.Trim() == xyz.Issuer.Trim()).FirstOrDefault();
                    var bin1 = bins_ppt.Where(u => u.Bin.Trim() == xyz.Acquirer.Trim()).FirstOrDefault();
                    if (bin == null || bin1 == null)
                    {
                        continue;
                    }

                    issuer = institutions.Where(y => y.Id == bin.InstId).FirstOrDefault().Name == null ? institutions.Where(y => y.Id == bin.InstId).FirstOrDefault().Name : institutions.Where(y => y.Id == bin.InstId).FirstOrDefault().Name;
                    acquirer = institutions.Where(y => y.Id == bin1.InstId).FirstOrDefault().Name == null ? institutions.Where(y => y.Id == bin1.InstId).FirstOrDefault().Name : institutions.Where(y => y.Id == bin1.InstId).FirstOrDefault().Name;

                    transaction = new Transaction();
                    try { transaction.pan = Logic.Logic.maskCardNumber(xyz.Pan, "######******####"); } catch (Exception ex) { }
                    transaction.responseCode = xyz.Respcode.ToString();
                    transaction.transactionDate = xyz.LocalDate == null ? DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") : Convert.ToDateTime(xyz.LocalDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                    transaction.transactionReference = xyz.Refnum;
                    transaction.stan = xyz.Origtrace.ToString();
                    transaction.transactionAmount = Convert.ToDecimal(xyz.Amount * 100);
                    transaction.transactionStore = "ISW_TRANSACTIONS";
                    transaction.terminalId = xyz.Termid;
                    transaction.retrievalReferenceNumber =/* xyz.Id.ToString();*/xyz.Refnum;
                    transaction.cardAcceptorLocation = xyz.Acceptorname;
                    transaction.issuerCode = xyz.Issuer.Trim();
                    transaction.acquirerCode = xyz.Acquirer.Trim();
                    transaction.customerReference = xyz.Refnum;
                    transaction.transactionType = xyz.Pcode.ToString().PadLeft(6, '0').Substring(0, 2).Trim() == "00" ? "BillPayment" : "Cash Withdrawal";
                    transaction.acquirer = acquirer;
                    transaction.issuer = issuer;
                    transaction.transactionCurrencyCode = "404";
                    transaction.terminalType = "1";
                    if (xyz.Pan.Substring(0, 6) == "506183")
                    {
                        transaction.cardScheme = xyz.Pan.Substring(0, 1) == "5" ? "Verve" : "VISA";
                    }
                    else
                    {
                        transaction.cardScheme = xyz.Pan.Substring(0, 1) == "5" ? "MasterCard" : "VISA";
                    }
                    //transaction.cardScheme = xyz.Pan.Substring(0, 1) == "5" ? "MasterCard" : "VISA";
                    transaction.acquirerCountry = "KE";
                    transaction.issuerCountry = "KE";
                    transaction.region = "Kenya";
                    transaction.settled = true;

                    transaction.merchantType = "REGULAR";
                    transaction.merchant = xyz.Merchant.ToString();
                    transaction.merchantCode = xyz.Merchant.ToString();

                    transactions.Add(transaction);
                }
                catch (Exception ex) { }


            }

            Logic.Logic.WriteLog("Transactions");
            Logic.Logic.WriteLog("Transactions");
            string json = JsonConvert.SerializeObject(transactions);
            Logic.Logic.WriteLog(json);


            return result != null ? (IActionResult)Ok(transactions) : NotFound();
        }
        [HttpGet("transactionapi/retrieve/single/")]
        public async Task<IActionResult> GetAccount2([FromQuery(Name = "start_date")] string START_DATE, [FromQuery(Name = "end_date")] string END_DATE, [FromQuery(Name = "account")] string ACCOUNT, [FromQuery(Name = "pan")] string PAN, [FromQuery(Name = "stan")] string STAN,
         [FromQuery(Name = "rrn")] string RRN, [FromQuery(Name = "terminal")] string TERMINAL)
        {




            var parsedDate = DateTime.ParseExact(START_DATE.Substring(0, 10), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var formattedSDate = parsedDate.ToString("dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

            var parsedDate_ = DateTime.ParseExact(END_DATE.Substring(0, 10), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            var formattedSDate_ = parsedDate_.ToString("dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

            string issuer = "";
            string acquirer = "";
            var institutions =
           this.modelContext.Institutions.FromSqlRaw(
            "[dbo].[sp_SelectAllinstitutions]").ToList();
            var bins_ppt =
           this.modelContext.PptBins.FromSqlRaw(
            "[dbo].[sp_SelectAllppt_bins]").ToList();



            DateTime sdate = DateTime.ParseExact(formattedSDate, "dd-MM-yyyy", null);
            DateTime edate = DateTime.ParseExact(formattedSDate_, "dd-MM-yyyy", null);
            string pan = String.IsNullOrWhiteSpace(PAN) ? "" : "and pan like '%" + PAN + "%'";
            string stan = String.IsNullOrWhiteSpace(STAN) ? "" : "and Origtrace like '%" + STAN + "%'";
            string tem = String.IsNullOrWhiteSpace(TERMINAL) ? "" : "and termid like '%" + TERMINAL + "%'";
            string rrn = String.IsNullOrWhiteSpace(RRN) ? "" : "and Refnum like '%" + RRN + "%'";
            string acc = String.IsNullOrWhiteSpace(ACCOUNT) ? "" : "and acctnum like '%" + ACCOUNT + "%'";
            string refnum = String.IsNullOrWhiteSpace(ACCOUNT) ? "" : "and Refnum like '%" + ACCOUNT + "%'";



            //var querry = new GetMultipleTrasaction(START_DATE.ToString(), END_DATE.ToString(), ACCOUNT, PAN, STAN, RRN, TERMINAL);
            //var sqlstmt = "SELECT * FROM dbo.shclog_non_ppt where LOCAL_DATE between '" + sdate + "' and '" + edate + "'" + pan + stan + tem + rrn + acc;
            var drtt = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + " " + "16:00:00";

            //var sqlstmt = "SELECT * FROM dbo.shclog_non_ppt where REV_DATE IS  NULL and LOCAL_DATE <  '" + drtt + "' and   LOCAL_DATE between '" + sdate + "' and '" + edate + "'" + pan + stan + tem + rrn + acc;


            /*var myTableResults =
              this.modelContext.ShclogNonPpt.FromSqlRaw(sqlstmt).ToList();*/
            /*var result = await _mediator.Send(querry);*/




            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@sdate",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = sdate
                        },
                         new SqlParameter() {
                            ParameterName = "@edate",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = edate
                        },
                          new SqlParameter() {
                            ParameterName = "@bdate",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = drtt
                        }
            };

            Logic.Logic.WriteLog("querry");


            var myTableResults =
                 this.modelContext.ShclogNonPpt.FromSqlRaw("[dbo].[sp_GetTransWithDates] @sdate, @edate,@bdate", param).ToList();

            if (!String.IsNullOrWhiteSpace(PAN))
            {
                myTableResults = myTableResults.Where(u => u.Pan == Logic.Logic.maskCardNumber(PAN, "######******####")).ToList();
            }
            if (!String.IsNullOrWhiteSpace(STAN))
            {
                myTableResults = myTableResults.Where(u => u.Origtrace == int.Parse(STAN)).ToList();
            }

            if (!String.IsNullOrWhiteSpace(TERMINAL))
            {
                myTableResults = myTableResults.Where(u => u.Termid == TERMINAL).ToList();
            }

            if (!String.IsNullOrWhiteSpace(RRN))
            {
                myTableResults = myTableResults.Where(u => u.Refnum == RRN).ToList();
            }
            if (!String.IsNullOrWhiteSpace(ACCOUNT))
            {
                myTableResults = myTableResults.Where(u => u.Acctnum == ACCOUNT).ToList();
            }

            var result = myTableResults;

            List<Transaction> transactions = new List<Transaction>();
            Transaction transaction = new Transaction();
            foreach (var xyz in result)
            {
                issuer = "";
                acquirer = "";

                var bin = bins_ppt.Where(u => u.Bin.Trim() == xyz.Issuer.Trim()).FirstOrDefault();
                var bin1 = bins_ppt.Where(u => u.Bin.Trim() == xyz.Acquirer.Trim()).FirstOrDefault();

                issuer = institutions.Where(y => y.Id == bin.InstId).FirstOrDefault().Name;
                acquirer = institutions.Where(y => y.Id == bin1.InstId).FirstOrDefault().Name;

                transaction = new Transaction();
                try { transaction.pan = Logic.Logic.maskCardNumber(xyz.Pan, "######******####"); } catch (Exception ex) { }
                transaction.responseCode = xyz.Respcode.ToString();
                transaction.transactionDate = xyz.LocalDate == null ? DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") : Convert.ToDateTime(xyz.LocalDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                transaction.transactionReference = xyz.Refnum;
                transaction.stan = xyz.Origtrace.ToString();
                transaction.transactionAmount = Convert.ToDecimal(xyz.Amount * 100);
                transaction.transactionStore = "ISW_TRANSACTIONS";
                transaction.terminalId = xyz.Termid;
                transaction.retrievalReferenceNumber =/* xyz.Id.ToString()*/xyz.Refnum; 
                transaction.cardAcceptorLocation = xyz.Acceptorname;
                transaction.issuerCode = xyz.Issuer.Trim();
                transaction.acquirerCode = xyz.Acquirer.Trim();

                transaction.customerReference = xyz.Refnum;
                transaction.transactionType = xyz.Pcode.ToString().PadLeft(6, '0').Substring(0, 2).Trim() == "00" ? "BillPayment" : "Cash Withdrawal";
                transaction.acquirer = acquirer;
                transaction.issuer = issuer;
                transaction.transactionCurrencyCode = "404";
                transaction.terminalType = "1";
                // transaction.cardScheme = xyz.Pan.Substring(0, 1) == "5" ? "MasterCard" : "VISA";
                if (xyz.Pan.Substring(0, 6) == "506183")
                {
                    transaction.cardScheme = xyz.Pan.Substring(0, 1) == "5" ? "Verve" : "VISA";
                }
                else
                {
                    transaction.cardScheme = xyz.Pan.Substring(0, 1) == "5" ? "MasterCard" : "VISA";
                }
                transaction.acquirerCountry = "KE";
                transaction.issuerCountry = "KE";
                transaction.region = "Kenya";
                transaction.settled = true;
                transaction.merchantType = "REGULAR";
                transaction.merchant = xyz.Merchant.ToString();
                transaction.merchantCode = xyz.Merchant.ToString();


                transactions.Add(transaction);



            }
            var tran = transactions.FirstOrDefault();

            return result != null ? (IActionResult)Ok(tran) : NotFound();
        }

        [HttpGet("transactionapi/settlement/history/")]
        public async Task<IActionResult> GetSettlements([FromQuery(Name = "uniquekey")] string uniquekey)
        {
            var institutions =
             this.modelContext.Institutions.FromSqlRaw(
              "[dbo].[sp_SelectAllinstitutions]").ToList();
            var bins_ppt =
           this.modelContext.PptBins.FromSqlRaw(
            "[dbo].[sp_SelectAllppt_bins]").ToList();
            Logic.Logic.WriteLog("uniquekey" + uniquekey);

            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@uniquekey",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = uniquekey
                        } };

            Logic.Logic.WriteLog("uniquekey" + uniquekey);
            var myTableResults =
                        this.modelContext.ShclogNonPpt.FromSqlRaw("[dbo].[sp_GetTransUniqueColumn] @uniquekey", param).ToList();

            ReversalResponse reversalResponse = new ReversalResponse();
            var result = myTableResults;
            string issuer = null;
            string acquirer = null;
            if (myTableResults.Count() > 0)
            {
                var tran1 = result[0];

                var bin = bins_ppt.Where(u => u.Bin.Trim() == myTableResults.FirstOrDefault().Issuer.Trim()).FirstOrDefault();
                var bin1 = bins_ppt.Where(u => u.Bin.Trim() == myTableResults.FirstOrDefault().Acquirer.Trim()).FirstOrDefault();

                issuer = institutions.Where(y => y.Id == bin.InstId).FirstOrDefault().Name;
                acquirer = institutions.Where(y => y.Id == bin1.InstId).FirstOrDefault().Name;

                reversalResponse.settlementReference = tran1.Refnum;
                reversalResponse.settlementDate = /*Convert.ToDateTime(tran1.StmtDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");*/DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                reversalResponse.settlementType = "Reversal";

                SettlementModel settlementModel = new SettlementModel();

                settlementModel.participant = issuer;
                settlementModel.role = "ISSUER";
                settlementModel.settlementInstitution = tran1.Issuer.Trim();
                settlementModel.amount = Convert.ToDecimal(tran1.RevAmt * 100);
                settlementModel.currency = "404";


                SettlementModel settlementModel1 = new SettlementModel();

                settlementModel1.participant = acquirer;
                settlementModel1.role = "ACQUIRER";
                settlementModel1.settlementInstitution = tran1.Acquirer.Trim();
                settlementModel1.amount = Convert.ToDecimal(tran1.RevAmt * 100);
                settlementModel1.currency = "404";




                List<SettlementModel> settlementModels = new List<SettlementModel>();
                settlementModels.Add(settlementModel);
                settlementModels.Add(settlementModel1);
                reversalResponse.settlements = settlementModels;

            }
            else
            {
                reversalResponse.settlementReference = null;
                reversalResponse.settlementDate = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                reversalResponse.settlementType = "Reversal";
                reversalResponse.settlements = null;
            }




            return result != null ? (IActionResult)Ok(reversalResponse) : NotFound();
        }
        [HttpGet("transactionapi/retrieve/unique/")]
        public async Task<IActionResult> GetAccount3([FromQuery(Name = "uniquekey")] string uniquekey)
        {
            try
            {
                /*  var querry = new GetByUniqueId(uniquekey);
                  var result = await _mediator.Send(querry);*/
                string issuer = "";
                string acquirer = "";
                var institutions =
                      this.modelContext.Institutions.FromSqlRaw(
                       "[dbo].[sp_SelectAllinstitutions]").ToList();
                var bins_ppt =
               this.modelContext.PptBins.FromSqlRaw(
                "[dbo].[sp_SelectAllppt_bins]").ToList();

                var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@uniquekey",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = uniquekey
                        } };

                Logic.Logic.WriteLog("uniquekey" + uniquekey);
                var myTableResults =
                            this.modelContext.ShclogNonPpt.FromSqlRaw("[dbo].[sp_GetTransUniqueColumn] @uniquekey", param).ToList();

                /*var result = await _mediator.Send(querry);*/
                var result = myTableResults;

                List<Transaction> transactions = new List<Transaction>();
                Transaction transaction = new Transaction();
                foreach (var xyz in result)
                {
                    issuer = "";
                    acquirer = "";

                    var bin = bins_ppt.Where(u => u.Bin.Trim() == xyz.Issuer.Trim()).FirstOrDefault();
                    var bin1 = bins_ppt.Where(u => u.Bin.Trim() == xyz.Acquirer.Trim()).FirstOrDefault();

                    issuer = institutions.Where(y => y.Id == bin.InstId).FirstOrDefault().Name;
                    acquirer = institutions.Where(y => y.Id == bin1.InstId).FirstOrDefault().Name;

                    transaction = new Transaction();
                    try
                    {
                        try { transaction.pan = Logic.Logic.maskCardNumber(xyz.Pan, "######******####"); } catch (Exception ex) { }
                    }
                    catch (Exception ex) { }
                    transaction.responseCode = xyz.Respcode.ToString();
                    transaction.transactionDate = xyz.LocalDate == null ? DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") : Convert.ToDateTime(xyz.LocalDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                    transaction.transactionReference = xyz.Refnum;
                    transaction.stan = xyz.Origtrace.ToString();
                    transaction.transactionAmount = Convert.ToDecimal(xyz.Amount * 100);
                    transaction.transactionStore = "ISW_TRANSACTIONS";
                    transaction.terminalId = xyz.Termid;
                    transaction.retrievalReferenceNumber = /*xyz.Id.ToString()*/xyz.Refnum;
                    transaction.cardAcceptorLocation = xyz.Acceptorname;
                    transaction.issuerCode = xyz.Issuer.Trim();
                    transaction.acquirerCode = xyz.Acquirer.Trim();
                    ////
                    transaction.customerReference = xyz.Refnum;
                    transaction.transactionType = xyz.Pcode.ToString().PadLeft(6, '0').Substring(0, 2).Trim() == "00" ? "BillPayment" : "Cash Withdrawal";
                    transaction.acquirer = acquirer;
                    transaction.issuer = issuer;
                    transaction.transactionCurrencyCode = "404";
                    transaction.terminalType = "1";
                    if (xyz.Pan.Substring(0, 6) == "506183")
                    {
                        transaction.cardScheme = xyz.Pan.Substring(0, 1) == "5" ? "Verve" : "VISA";
                    }
                    else
                    {
                        transaction.cardScheme = xyz.Pan.Substring(0, 1) == "5" ? "MasterCard" : "VISA";
                    }

                    transaction.acquirerCountry = "KE";
                    transaction.issuerCountry = "KE";
                    transaction.region = "Kenya";
                    transaction.settled = true;
                    transaction.merchantType = "REGULAR";
                    transaction.merchant = xyz.Merchant.ToString();
                    transaction.merchantCode = xyz.Merchant.ToString();

                    transactions.Add(transaction);



                }
                var tran = transactions.FirstOrDefault();

                return result != null ? (IActionResult)Ok(tran) : NotFound();
            }
            catch (Exception ex)
            {
                Logic.Logic.WriteLog("Errorlog" + ex.ToString());

            }
            return NotFound();
        }

        [HttpPut("transactionapi/retrieve/adjust/")]
        public async Task<IActionResult> GetAccount4([FromQuery(Name = "uniquekey")] string uniquekey, [FromQuery(Name = "disputeamount")] decimal disputeamount)
        {
            /*            var querry = new GetByUniqueId(uniquekey);
                        var result = await _mediator.Send(querry);*/


            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@uniquekey",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = uniquekey
                        } };

            Logic.Logic.WriteLog("uniquekey" + uniquekey);
            var myTableResults =
                        this.modelContext.ShclogNonPpt.FromSqlRaw("[dbo].[sp_GetTransUniqueColumn] @uniquekey", param).ToList();
            ReversalResponse reversalResponse = new ReversalResponse();
            var result = myTableResults;
            string issuer = null;
            string acquirer = null;
            var institutions =
              this.modelContext.Institutions.FromSqlRaw(
               "[dbo].[sp_SelectAllinstitutions]").ToList();
            var bins_ppt =
           this.modelContext.PptBins.FromSqlRaw(
            "[dbo].[sp_SelectAllppt_bins]").ToList();
            if (myTableResults.Count() > 0)
            {
                var tran1 = result[0];
                tran1.RevAmt = /*tran1.Amount*/disputeamount;
                tran1.RevDate = DateTime.Now.AddDays(1);

                modelContext.Entry(tran1).State = EntityState.Modified;
                modelContext.SaveChanges();



                var bin = bins_ppt.Where(u => u.Bin.Trim() == myTableResults.FirstOrDefault().Issuer.Trim()).FirstOrDefault();
                var bin1 = bins_ppt.Where(u => u.Bin.Trim() == myTableResults.FirstOrDefault().Acquirer.Trim()).FirstOrDefault();

                issuer = institutions.Where(y => y.Id == bin.InstId).FirstOrDefault().Name;
                acquirer = institutions.Where(y => y.Id == bin1.InstId).FirstOrDefault().Name;


                reversalResponse.settlementReference = tran1.Refnum;
                reversalResponse.settlementDate = /*Convert.ToDateTime(tran1.StmtDate).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");*/DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                reversalResponse.settlementType = "Reversal";

                SettlementModel settlementModel = new SettlementModel();

                settlementModel.participant = issuer;
                settlementModel.role = "ISSUER";
                settlementModel.settlementInstitution = tran1.Issuer.Trim();
                settlementModel.amount = Convert.ToDecimal(tran1.RevAmt * 100);
                settlementModel.currency = "404";

                SettlementModel settlementModel1 = new SettlementModel();

                settlementModel1.participant = acquirer;
                settlementModel1.role = "ACQUIRER";
                settlementModel1.settlementInstitution = tran1.Acquirer.Trim();
                settlementModel1.amount = Convert.ToDecimal(tran1.RevAmt * 100);
                settlementModel1.currency = "404";




                List<SettlementModel> settlementModels = new List<SettlementModel>();
                settlementModels.Add(settlementModel);
                settlementModels.Add(settlementModel1);
                reversalResponse.settlements = settlementModels;


                ///Populate Rev Audit
                ShclogRevaudit shclogRevaudit = new ShclogRevaudit();
                shclogRevaudit.ShclogId = tran1.Id;
                shclogRevaudit.ShclogName = "SHCLOG_NON_PPT";
                shclogRevaudit.ApprovedBy = "PAYNET\\Arbiter";
                shclogRevaudit.ApprDate = DateTime.Now;
                shclogRevaudit.ReversedBy = "PAYNET\\Arbiter";
                shclogRevaudit.ReversedOn= DateTime.Now;
                shclogRevaudit.Commited = false;
                shclogRevaudit.RevType = "BOTH";

                modelContext.ShclogRevaudit.Add(shclogRevaudit);
                modelContext.SaveChanges();



            }
            else
            {
                reversalResponse.settlementReference = null;
                reversalResponse.settlementDate = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                reversalResponse.settlementType = "Reversal";
                reversalResponse.settlements = null;
            }




            return result != null ? (IActionResult)Ok(reversalResponse) : NotFound();
        }

    }


}
