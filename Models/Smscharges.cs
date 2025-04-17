using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Smscharges
    {
        public short SmslinkTypeId { get; set; }
        public string InstAbbrev { get; set; }
        public double? Cost { get; set; }
        public string Currency { get; set; }

        public SmslinkTypes SmslinkType { get; set; }
    }
}
