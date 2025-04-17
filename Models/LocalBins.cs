using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class LocalBins
    {
        public int Id { get; set; }
        public string Bin1 { get; set; }
        public string Bin2 { get; set; }
        public string Digit { get; set; }
        public string Cnt { get; set; }
        public string Letter { get; set; }
    }
}
