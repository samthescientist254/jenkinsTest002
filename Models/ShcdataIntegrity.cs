using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ShcdataIntegrity
    {
        public long Id { get; set; }
        public DateTime? CheckDateTime { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int? Offsitecount { get; set; }
        public int? Livecount { get; set; }
    }
}
