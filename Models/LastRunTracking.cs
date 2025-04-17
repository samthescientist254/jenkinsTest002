using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class LastRunTracking
    {
        public string Taskname { get; set; }
        public DateTime? LastSuccRun { get; set; }
    }
}
