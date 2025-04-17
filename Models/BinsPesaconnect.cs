using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class BinsPesaconnect
    {
        public string Issuer { get; set; }
        public string Acquirer { get; set; }
        public int? InstId { get; set; }
    }
}
