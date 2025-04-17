using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class AtmAccounts
    {
        public string Instabbrev { get; set; }
        public string Acctkey { get; set; }
        public string Bankcode { get; set; }
        public string Branchcode { get; set; }
        public string Accountno { get; set; }
        public string Accountname { get; set; }
        public string Currency { get; set; }
    }
}
