using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Erroreps
    {
        public int Id { get; set; }
        public string Emailto { get; set; }
        public string Emailcc { get; set; }
        public string Emailbcc { get; set; }
        public int Minutes { get; set; }
        public int LocalTimePpt { get; set; }
        public int? LocalTimeNonPpt { get; set; }
        public string Respcodes { get; set; }
        public string RespcodesExceptions { get; set; }
        public string Bins { get; set; }
        public string Subject { get; set; }
        public string Smsto { get; set; }
        public DateTime? SmsLastSent { get; set; }
        public string Acquirer { get; set; }
        public int? Active { get; set; }
        public string AlertGroup { get; set; }
        public string Termid { get; set; }
        public int? Saf { get; set; }
        public string Msgtype { get; set; }
        public string Pcode { get; set; }
        public string BinsExceptions { get; set; }
    }
}
