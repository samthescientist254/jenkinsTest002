using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Smsgatewaystatus
    {
        public long Id { get; set; }
        public long StartupTime { get; set; }
        public DateTime? DtStartupTime { get; set; }
        public bool? Usable { get; set; }
        public string LastErrorMessage { get; set; }
        public bool? InitializedSuccessfully { get; set; }
        public DateTime? LastFailedRecvTime { get; set; }
        public DateTime? LastFailedSendTime { get; set; }
        public DateTime? LastFailedClickatellSendTime { get; set; }
        public DateTime? LastFailedMachsendTime { get; set; }
        public DateTime? LastSuccessfulClickatellSendTime { get; set; }
        public DateTime? LastSuccessfulMachsendTime { get; set; }
        public DateTime? LastFailedPhone1SendTime { get; set; }
        public DateTime? LastSuccessfulPhone1SendTime { get; set; }
        public DateTime? LastSuccessfulRecvTime { get; set; }
        public string LastSuccessfulRoute { get; set; }
        public string LastFailedRoute { get; set; }
        public int? FailedClickatellAttempts { get; set; }
        public int? FailedMachattempts { get; set; }
        public int? FailedPhone1Attempts { get; set; }
        public int? SuccessfulClickatellAttempts { get; set; }
        public int? SuccessfulMachattempts { get; set; }
        public int? SuccessfulPhone1Attempts { get; set; }
        public int? SuccessfulReadAttempts { get; set; }
        public int? FailedReadAttempts { get; set; }
        public int? FailedSendAttempts { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public DateTime? ShutdownTime { get; set; }
        public int? ReceivedMessages { get; set; }
        public int? CurrentClickatellBalance { get; set; }
        public int? CurrentMachbalance { get; set; }
        public int? CurrentPhoneBalance { get; set; }
        public int? ClickatellBalWarningSent { get; set; }
        public int? MachbalWarningSent { get; set; }
        public int? PhoneBalWarningSent { get; set; }
        public int? ErrorCount { get; set; }
        public string LinkId { get; set; }
    }
}
