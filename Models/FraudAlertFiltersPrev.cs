using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class FraudAlertFiltersPrev
    {
        public string FilterName { get; set; }
        public string EmailSubjectPrefix { get; set; }
        public int? PeriodFrom { get; set; }
        public int? PeriodTo { get; set; }
        public string PcodesCsv { get; set; }
        public string AcquirersCsv { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateFrom { get; set; }
        public string SendEmailTo { get; set; }
    }
}
