using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SmslinkTypes
    {
        public SmslinkTypes()
        {
            Smscharges = new HashSet<Smscharges>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public bool? IsEnabled { get; set; }
        public string CreditAvailableFlag { get; set; }
        public DateTime? LastZerocreditAlertTime { get; set; }
        public DateTime? LastOkcreditAlertTime { get; set; }
        public decimal? AvailableBalance { get; set; }
        public DateTime? LastBalUpdateTime { get; set; }
        public decimal? LowBalThreshold { get; set; }
        public string LowBalSmsalert { get; set; }
        public string LowBalEmailAlert { get; set; }
        public bool? LowBalAlertSent { get; set; }
        public DateTime? LowBalAlertSentAt { get; set; }
        public short? LowBalAlertIntervalMin { get; set; }
        public bool? CanReceiveMessages { get; set; }

        public ICollection<Smscharges> Smscharges { get; set; }
    }
}
