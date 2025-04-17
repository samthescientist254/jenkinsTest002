using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SettlementProcGrps
    {
        public int Id { get; set; }
        public string ProcGrp { get; set; }
        public string Rundaysofweek { get; set; }
        public int? Cutofftime { get; set; }
        public bool? RunOnHolidays { get; set; }
    }
}
