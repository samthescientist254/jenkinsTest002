using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SmsAlerts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Message { get; set; }
    }
}
