﻿using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ShclogTest
    {
        public string Rowid { get; set; }
        public decimal? Msgtype { get; set; }
        public string Pan { get; set; }
        public decimal? Pcode { get; set; }
        public decimal? Txntype { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Trace { get; set; }
        public decimal? LocalTime { get; set; }
        public DateTime? LocalDate { get; set; }
        public string Acquirer { get; set; }
        public string Issuer { get; set; }
        public decimal? Respcode { get; set; }
        public decimal? Revcode { get; set; }
        public decimal? Saf { get; set; }
        public string Authnum { get; set; }
        public string Termid { get; set; }
        public string Acceptorname { get; set; }
        public string Termloc { get; set; }
        public string Acctnum { get; set; }
        public DateTime? Dateadded { get; set; }
        public DateTime? StmtDate { get; set; }
        public DateTime? RevDate { get; set; }
        public decimal? RevAmt { get; set; }
        public DateTime? ImpDate { get; set; }
        public DateTime? StmtDate2 { get; set; }
        public long? SmsId { get; set; }
        public DateTime? LocalDateTime { get; set; }
        public string Billing { get; set; }
        public decimal? RevMsgtype { get; set; }
        public decimal? RevRespcode { get; set; }
        public decimal? RevAmount { get; set; }
        public string InstAbbrev { get; set; }
        public string IssuerAbbrev { get; set; }
        public short? LocalDateValidity { get; set; }
        public int Id { get; set; }
        public string Refnum { get; set; }
        public int? Origtrace { get; set; }
        public int? Origmsg { get; set; }
        public DateTime? Origdate { get; set; }
        public int? Origtime { get; set; }
        public int? Merchant { get; set; }
        public byte[] PanEnc { get; set; }
        public decimal? CopyBatchid { get; set; }
    }
}
