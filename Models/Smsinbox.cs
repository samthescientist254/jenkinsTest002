using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Smsinbox
    {
        public long Id { get; set; }
        public string Cli { get; set; }
        public string Msg { get; set; }
        public string Status { get; set; }
        public DateTime Datesent { get; set; }
        public string Comments { get; set; }
        public string Crmcaseid { get; set; }
        public DateTime Dateadded { get; set; }
        public string Source { get; set; }
        public string SmsAccount { get; set; }
        public string Application { get; set; }
        public string Msgid { get; set; }
    }
}
