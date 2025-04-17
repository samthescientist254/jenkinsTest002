using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SmssenderIds
    {
        public short Id { get; set; }
        public string SenderId { get; set; }
        public string LinkName { get; set; }
        public bool? Enabled { get; set; }
        public string TranslateTo { get; set; }
    }
}
