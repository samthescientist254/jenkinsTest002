using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SmsStatusChanges
    {
        public long Id { get; set; }
        public string Smstable { get; set; }
        public long SmsId { get; set; }
        public string Origstatus { get; set; }
        public string Newstatus { get; set; }
        public string Username { get; set; }
        public DateTime? Currdate { get; set; }
    }
}
