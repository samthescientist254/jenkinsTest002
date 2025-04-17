using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class FraudAlertConfigHistoryPrev
    {
        public long Id { get; set; }
        public DateTime? CurrDate { get; set; }
        public long Acctnum { get; set; }
        public bool? SendEmail { get; set; }
        public bool? SendSms { get; set; }
        public string EmailAlertTo { get; set; }
        public string SmsalertTo { get; set; }
        public bool? OnWatch { get; set; }
        public DateTime? LastTxnTime { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateFrom { get; set; }
        public string FilterName { get; set; }
        public string Pan { get; set; }
        public string SearchBy { get; set; }
        public string FullName { get; set; }
    }
}
