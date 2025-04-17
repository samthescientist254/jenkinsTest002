using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class TkReversals
    {
        public long Id { get; set; }
        public long? Shcid { get; set; }
        public DateTime? RevDatetime { get; set; }
        public string RevBy { get; set; }
        public int? Revcode { get; set; }
        public string TkResponse { get; set; }
    }
}
