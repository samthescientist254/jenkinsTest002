using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ShclogNonPptExt
    {
        public long Id { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public DateTime? AutoRevTime { get; set; }
        public bool? IsPesaConnect { get; set; }
        public bool? IsVisa { get; set; }
        public bool? IsOnus { get; set; }
    }
}
