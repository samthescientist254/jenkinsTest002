using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Pptcharges
    {
        public int Id { get; set; }
        public string IssuerBin { get; set; }
        public DateTime? UptoDate { get; set; }
        public double? Cwdcharge { get; set; }
        public double? Ppcharge { get; set; }
        public double? Bpcharge { get; set; }
        public string IssuerShortName { get; set; }
        public double? Mstmtcharge { get; set; }
        public double? Bicharge { get; set; }
    }
}
