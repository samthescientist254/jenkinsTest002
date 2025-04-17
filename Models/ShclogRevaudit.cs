using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ShclogRevaudit
    {
        public long Id { get; set; }
        public long ShclogId { get; set; }
        public string ShclogName { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprDate { get; set; }
        public string ReversedBy { get; set; }
        public bool? Commited { get; set; }
        public DateTime? ReversedOn { get; set; }
        public string RevType { get; set; }
    }
}
