using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Atmcutoff2
    {
        public string Bin { get; set; }
        public string Termid { get; set; }
        public DateTime? Dtfrom { get; set; }
        public DateTime? Dtto { get; set; }
    }
}
