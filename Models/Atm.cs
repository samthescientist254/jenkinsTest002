using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Atm
    {
        public decimal? Unit { get; set; }
        public string Termid { get; set; }
        public int? Provinceid { get; set; }
        public string Location { get; set; }
        public string GroupName { get; set; }
        public string Acceptorname { get; set; }
        public string Mobile { get; set; }
        public string Gprsno { get; set; }
        public int? Regionid { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public bool? Selected { get; set; }
        public decimal? Curbalance { get; set; }
        public decimal? Balpercent { get; set; }
        public DateTime? Lastloaddate { get; set; }
        public string ShowBal { get; set; }
        public decimal? Budgetload { get; set; }
        public decimal? Actualload { get; set; }
        public int? Budgetcount { get; set; }
        public int? Active { get; set; }
        public string Nagiostatus { get; set; }
        public int? Alertsfromhr { get; set; }
        public int? Alertstohr { get; set; }
        public DateTime? CommentUpdateTm { get; set; }
        public string Lastupdateby { get; set; }
        public string Lastupdatefrom { get; set; }
        public string Acquirer { get; set; }
        public DateTime? Firsttxndate { get; set; }
        public DateTime? Moveto76 { get; set; }
        public bool? Bal76 { get; set; }
        public DateTime? PesaconnDt { get; set; }
    }
}
