using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionDataApiSettlement.Logic;
using TransactionDataApiSettlement.Models.TX;
using TransactionDataApiSettlement.Models.XML;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TransactionDataApiSettlement.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TxController : ControllerBase
    {
        ApiCaller apiCaller = new ApiCaller();
        private readonly IOptions<MySetting> appSettings;
        public TxController(IOptions<MySetting> _appSettings)
        {
            appSettings = _appSettings;
        }


        [HttpGet("v2/cms/tranzaxis/cardholderinformation")]
        public async Task<IActionResult> PostAsync([FromQuery(Name = "instId")] int instId)
        {
            CardDetailSearch value = new CardDetailSearch();
            value.instid = instId;
            string res = await apiCaller.postAsyncjson(appSettings.Value.kadiurl + "/tx/cardholderinformation", JsonConvert.SerializeObject(value));
            TxResponse cardHolderInformation = JsonConvert.DeserializeObject<TxResponse>(res);
            cardHolderInformation.cardHolderInformation = cardHolderInformation.cardHolderInformartion;
            cardHolderInformation.cardHolderInformartion = null;
          /*  foreach (var att in cardHolderInformation.cardHolderInformation)
            {
                
                    att.IsoCountryCode = "566";
                
            }*/
            return (IActionResult)Ok(cardHolderInformation);
        }
        [HttpGet("v2/cms/tranzaxis/accountbalance")]
        public async Task<IActionResult> PostBal([FromQuery(Name = "instId")] int instId)
        {
            CardDetailSearch value = new CardDetailSearch();
            value.instid = instId;
            string res = await apiCaller.postAsyncjson(appSettings.Value.kadiurl + "/tx/accountbalance", JsonConvert.SerializeObject(value));
            TxResponse cardHolderInformation = JsonConvert.DeserializeObject<TxResponse>(res);
            
            return (IActionResult)Ok(cardHolderInformation);
        }
        [HttpGet("v2/cms/tranzaxis/accountinformation")]
        public async Task<IActionResult> PostAsyncAccount([FromQuery(Name = "instId")] int instId)
        {
            CardDetailSearch value = new CardDetailSearch();
            value.instid = instId;
            string res = await apiCaller.postAsyncjson(appSettings.Value.kadiurl + "/tx/accountinformation", JsonConvert.SerializeObject(value));
           
            TxResponse accountinformation = JsonConvert.DeserializeObject<TxResponse>(res);
            foreach (var att in accountinformation.accInfo)
            {
                {
                    if (att.statusCode.Trim() == "New")
                    {
                        att.statusCode = "1";
                    }
                    else
                    {
                        att.statusCode = "2";
                    }
                    att.cardType = "1";
                    att.statementType = "3";
                    att.annualFeeFlag = "0";
                    att.annualFeeMonth = "12";
                }
            }

            return (IActionResult)Ok(accountinformation);
        }
        [HttpGet("v2/cms/tranzaxis/companyinformation")]
        public async Task<IActionResult> PostAsyncCompany([FromQuery(Name = "instId")] int instId)
        {
            CardDetailSearch value = new CardDetailSearch();
            value.instid = instId;
            string res = await apiCaller.postAsyncjson(appSettings.Value.kadiurl + "/tx/companyinformation", JsonConvert.SerializeObject(value));
            TxResponse companyinformation = JsonConvert.DeserializeObject<TxResponse>(res);
            companyinformation.singleCompany = companyinformation.company.FirstOrDefault();
            companyinformation.singleCompany.IsoCountryCode = companyinformation.company.FirstOrDefault().IsoCountryCode;
            companyinformation.singleCompany.CardType = "1";
            companyinformation.singleCompany.OrganizationHierarchyManagementIndicator = "1";
            companyinformation.singleCompany.FiscalYearDate = "12/31";
            companyinformation.company = null;
            return (IActionResult)Ok(companyinformation);
        }

        [HttpGet("v2/cms/tranzaxis/companyBillingReportingPeriod")]
        public async Task<IActionResult> PostAsyncBillingReportingPeriod([FromQuery(Name = "instId")] int instId)
        {
            CardDetailSearch value = new CardDetailSearch();
            value.instid = instId;
            string res = await apiCaller.postAsyncjson(appSettings.Value.kadiurl + "/tx/companyinformation", JsonConvert.SerializeObject(value));
            TxResponse BillingReportingPeriod = JsonConvert.DeserializeObject<TxResponse>(res);

            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            var myDate = lastDayOfMonth;
            var a = string.Format("{0:yy}{1:D3}", myDate, myDate.DayOfYear);

            companyBillingReportingPeriod companyBillingReportingPeriod = new companyBillingReportingPeriod();
            companyBillingReportingPeriod.loadTransactionCode = "1";
            companyBillingReportingPeriod.companyIdentification = BillingReportingPeriod.company.FirstOrDefault().CompanyID;
            companyBillingReportingPeriod.period = a;
            companyBillingReportingPeriod.cardType = "1";
            companyBillingReportingPeriod.startDate = firstDayOfMonth.ToString("dd-MM-yyyy");
            companyBillingReportingPeriod.endDate = lastDayOfMonth.ToString("dd-MM-yyyy");
            if (lastDayOfMonth.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
            {
                companyBillingReportingPeriod.periodCompleteIndicator = "1";
            }
            else
            {
                companyBillingReportingPeriod.periodCompleteIndicator = "0";
            }

            BillingReportingPeriod.companyBillingReportingPeriod = companyBillingReportingPeriod;
            BillingReportingPeriod.company = null;
            return (IActionResult)Ok(BillingReportingPeriod);
        }
      

        [HttpGet("v2/cms/tranzaxis/transactions")]
        public async Task<IActionResult> PostAsyncTran([FromQuery(Name = "instId")] int instId, [FromQuery(Name = "startDate")] string startDate, [FromQuery(Name = "enddate")] string endDate)
        {
            try
            {
                CardDetailSearch value = new CardDetailSearch();

                value.instid = instId;
                value.startDate = startDate;
                value.enddate = endDate;

                string res = await apiCaller.postAsyncjson(appSettings.Value.kadiurl + "/tx/transactions", JsonConvert.SerializeObject(value));
                TxResponse transactions = JsonConvert.DeserializeObject<TxResponse>(res);
                /* var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(transactions.txTransaction);
                 List<TxTranRes> trans= JsonConvert.DeserializeObject<List<TxTranRes>>(jsonString);*/
                List<TxTranRes> tranRes = new List<TxTranRes>();

                string res2 = await apiCaller.postAsyncjson(appSettings.Value.kadiurl + "/tx/accountinformation", JsonConvert.SerializeObject(value));

                TxResponse accountinformation = JsonConvert.DeserializeObject<TxResponse>(res2);
                string bin = accountinformation.accInfo.FirstOrDefault().AccountNumber.Substring(0, 6);

                DateTime date = DateTime.Now;
                var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                var myDate = lastDayOfMonth;
                var a = string.Format("{0:yy}{1:D3}", myDate, myDate.DayOfYear);

                foreach (var tran in transactions.txTransaction.Where(u => u.BILLINGAMOUNT.Trim().Length > 0).ToList())
                {
                    var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(tran);
                    TxTranRes tra = JsonConvert.DeserializeObject<TxTranRes>(jsonString);
                    tra.accountNumber = accountinformation.accInfo.Where(p => p.cardholderId == tran.TOKENID).FirstOrDefault().AccountNumber;
                    tra.postingDate = tran.POSTINGDAY;
                    tra.period = tran.TRANSACTIONDATE;
                    tra.LOADTRANSACTIONCODE = "4";
                    //tra.RETRIEVALREFNUMBER = tran.SEQUENCENUMBER;
                    tra.transactionReference = tran.SEQUENCENUMBER;
                    tra.sequenceNumber = tran.SEQUENCENUMBER;
                    tra.SUPPLIERISOCOUNTRYCODE = tran.SOURCECURRENCYCODE;
                    tra.BILLINGCURRENCYCODE = tran.SOURCECURRENCYCODE;
                    tra.TRANSACTIONTYPECODE = "00";
                    //tra.MERCHANTCATEGORYCODE = "6011";
                    tra.ACQUIRINGBIN = bin;

                    tra.period = a;
                    tranRes.Add(tra);
                }
                transactions.txTrans = tranRes.Where(u => u.BILLINGAMOUNT.Trim().Length > 0).ToList();
                transactions.txTransaction = null;


                return (IActionResult)Ok(transactions);
            }
            catch (Exception ex) {
                Logic.Logic.WriteLog("Errorlog" + ex.ToString());
            }
            return (IActionResult)Ok();
        }


    }
}
