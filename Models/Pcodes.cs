using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Pcodes
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public string StanchartAbbrev { get; set; }
    }
}
