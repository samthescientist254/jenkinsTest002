using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SmsHttplinkExceptions
    {
        public string MobileNoPrefix { get; set; }
        public bool? CanSendViaHttpLink { get; set; }
        public string Description { get; set; }
    }
}
