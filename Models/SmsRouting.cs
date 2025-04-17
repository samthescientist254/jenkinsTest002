using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SmsRouting
    {
        public int Id { get; set; }
        public string RuleName { get; set; }
        public string SenderId { get; set; }
        public string MobileNoPrefix { get; set; }
        public string RouteSeq { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime? LastChangedAt { get; set; }
        public string LastChangedBy { get; set; }
        public string LastChangedFrom { get; set; }
        public bool? Active { get; set; }
    }
}
