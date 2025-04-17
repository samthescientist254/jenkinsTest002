using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Msmq
    {
        public int Id { get; set; }
        public string Queue { get; set; }
        public int? Maxmsg { get; set; }
        public int? Maxsms { get; set; }
        public int? Smscount { get; set; }
        public int? Smsspan { get; set; }
        public DateTime? Lastsms { get; set; }
        public string SmsNos { get; set; }
        public string Emails { get; set; }
        public int? Maxemails { get; set; }
        public int? Emailssent { get; set; }
        public DateTime? Lastemail { get; set; }
        public int? Emailspan { get; set; }
    }
}
