using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class UserAllowedSenderIds
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string AllowedSenderIdsCsv { get; set; }
        public bool? Enabled { get; set; }
    }
}
