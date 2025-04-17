using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SmsgwayUsers
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AllowedIps { get; set; }
        public string LastAppName { get; set; }
        public string LastAccessFrom { get; set; }
        public long? Smscount { get; set; }
        public byte[] PasswordHsh { get; set; }
        public string LastSuccessfulAccessFrom { get; set; }
        public DateTime? LastAccessAt { get; set; }
        public DateTime? LastSuccessfulAccessAt { get; set; }
        public string AllowedSenderIds { get; set; }
        public short? MinPriority { get; set; }
    }
}
