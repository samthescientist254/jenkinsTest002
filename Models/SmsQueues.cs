using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SmsQueues
    {
        public int Qid { get; set; }
        public string Qpath { get; set; }
        public string Hostname { get; set; }
        public int? Active { get; set; }
        public DateTime? DrainerStartTime { get; set; }
        public string Qname { get; set; }
        public string Destination { get; set; }
        public bool? Txnal { get; set; }
    }
}
