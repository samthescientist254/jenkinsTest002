using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class EmailAccounts
    {
        public string Accountname { get; set; }
        public string Description { get; set; }
        public string Smtpserver { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Authrequired { get; set; }
    }
}
