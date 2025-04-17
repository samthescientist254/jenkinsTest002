using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ProcessTracking
    {
        public string Process { get; set; }
        public decimal? LastRunTime { get; set; }
    }
}
