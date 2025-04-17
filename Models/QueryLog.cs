using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class QueryLog
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string ClientMachine { get; set; }
        public string QueryRef { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? EndedAt { get; set; }
        public bool? Successful { get; set; }
        public string Result { get; set; }
        public string Query { get; set; }
        public string ServerMachine { get; set; }
    }
}
