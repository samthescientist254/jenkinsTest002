using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class NagiosCassettes
    {
        public int Id { get; set; }
        public string Termid { get; set; }
        public string Location { get; set; }
        public string Service { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime? LastStatusUpdate { get; set; }
        public DateTime? LastTimeOk { get; set; }
        public int? DowntimeInDays { get; set; }
        public string Name { get; set; }
        public string ValStatus { get; set; }
        public int? ValInitial { get; set; }
        public int? ValRemaining { get; set; }
        public int? ValDispensed { get; set; }
        public int? ValDispToCust { get; set; }
        public int? ValDenomination { get; set; }
        public string LatestStatus { get; set; }
        public DateTime? LatestStatusTime { get; set; }
    }
}
