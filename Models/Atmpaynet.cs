using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Atmpaynet
    {
        public string Unit { get; set; }
        public DateTime? DtFrom { get; set; }
        public DateTime? DtTo { get; set; }
        public string Bin { get; set; }
    }
}
