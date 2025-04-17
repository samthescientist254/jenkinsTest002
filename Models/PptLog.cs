using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PptLog
    {
        public long Id { get; set; }
        public DateTime? LogTime { get; set; }
        public string LogCategory { get; set; }
        public string LogMsg { get; set; }
    }
}
