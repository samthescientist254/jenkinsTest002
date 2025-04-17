using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PrimeAccounts
    {
        public int Id { get; set; }
        public string Branch { get; set; }
        public string Acctnum { get; set; }
        public string Acctname { get; set; }
        public string Acctype { get; set; }
    }
}
