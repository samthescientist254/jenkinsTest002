using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SmsFiles
    {
        public long Id { get; set; }
        public DateTime? SmsDate { get; set; }
        public int? SmsTime { get; set; }
        public string Pan { get; set; }
        public long? RetRefNum { get; set; }
        public decimal? Trace { get; set; }
        public decimal? Msgtype { get; set; }
        public decimal? Pcode { get; set; }
        public decimal? Respcode { get; set; }
        public decimal? Amount { get; set; }
        public string Termid { get; set; }
        public string Matched { get; set; }
        public int? SelfId { get; set; }
        public DateTime? RepDate { get; set; }
        public DateTime? SmsDateTime { get; set; }
        public long? LineNo { get; set; }
        public DateTime? Dateadded { get; set; }
    }
}
