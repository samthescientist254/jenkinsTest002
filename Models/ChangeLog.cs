using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ChangeLog
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string TabName { get; set; }
        public string ColName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
