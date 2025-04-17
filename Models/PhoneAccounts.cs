using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PhoneAccounts
    {
        public int Id { get; set; }
        public string LinkName { get; set; }
        public int? Enabled { get; set; }
        public string HttpSmsUrl { get; set; }
        public string HttpApiId { get; set; }
        public string HttpSmsUid { get; set; }
        public string HttpSmsPwd { get; set; }
        public int? HttpSmsBal { get; set; }
        public int? MinHttpBal { get; set; }
        public int? HttpRcvEnabled { get; set; }
        public int? HttpSndEnabled { get; set; }
        public int PhonePort { get; set; }
        public int? PhoneBaud { get; set; }
        public int? MinPhoneBal { get; set; }
        public int? PhoneRcvEnabled { get; set; }
        public int? PhoneSndEnabled { get; set; }
        public string PhoneSimPin { get; set; }
        public string SmsAccount { get; set; }
        public string ProxyHost { get; set; }
        public int? ProxyPort { get; set; }
        public int? UseProxy { get; set; }
        public string ProxyUsername { get; set; }
        public string ProxyPassword { get; set; }
        public int? PhoneLinkReInitIntervalInMin { get; set; }
        public string Instabbrev { get; set; }
        public int? DisableIndications { get; set; }
    }
}
