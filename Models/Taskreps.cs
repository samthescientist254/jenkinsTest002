using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Taskreps
    {
        public int Id { get; set; }
        public int Taskid { get; set; }
        public int Repid { get; set; }
        public string Type { get; set; }
        public string Cntqry { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Active { get; set; }
        public string Fileext { get; set; }
        public bool? Pgpencrypt { get; set; }
        public string Targetdbid { get; set; }

        public Reports Rep { get; set; }
        public Tasks Task { get; set; }
    }
}
