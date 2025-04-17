using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class EodLog
    {
        public long Id { get; set; }
        public DateTime EodDate { get; set; }
        public string ProcName { get; set; }
        public bool? Completed { get; set; }
    }
}
