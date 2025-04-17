using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Smsoutbox
    {
        public long Id { get; set; }
        public string Da { get; set; }
        public string Msg { get; set; }
        public string Route { get; set; }
        public string Status { get; set; }
        public string Sentby { get; set; }
        public DateTime? Datesent { get; set; }
        public int RetryCnt { get; set; }
        public DateTime Dateadded { get; set; }
        public string Application { get; set; }
        public string SmsAccount { get; set; }
        public string Sendresult { get; set; }
        public short? Priority { get; set; }
        public string SrcRef { get; set; }
        public string Username { get; set; }
        public int? HttpStatus { get; set; }
        public string Msgid { get; set; }
        public string RouteUsed { get; set; }
        public int Sendcount { get; set; }
        public int? Delivered { get; set; }
        public string DelivDetails { get; set; }
        public int? DelivChkCnt { get; set; }
        public DateTime? DelivLastChk { get; set; }
        public int? SmsCount { get; set; }
        public decimal? SendDurationMs { get; set; }
        public int? CsMsg { get; set; }
    }
}
