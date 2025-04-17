using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class EmailAlerts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Emailto { get; set; }
        public string Emailcc { get; set; }
        public string Emailbcc { get; set; }
        public string Message { get; set; }
        public string Attachment { get; set; }
    }
}
