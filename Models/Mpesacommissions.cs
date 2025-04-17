using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Mpesacommissions
    {
        public short Id { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int MinAmount { get; set; }
        public int? MaxAmount { get; set; }
        public decimal? Commission { get; set; }
        public bool? Active { get; set; }
    }
}
