using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class NoonStats
    {
        public long Id { get; set; }
        public string Procgrp { get; set; }
        public DateTime? Targetdate { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public int? Cwdcount { get; set; }
        public decimal? Cwdamount { get; set; }
    }
}
