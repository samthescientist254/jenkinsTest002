using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Tasks
    {
        public Tasks()
        {
            Taskreps = new HashSet<Taskreps>();
        }

        public int Id { get; set; }
        public int? Priority { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Emailto { get; set; }
        public string Emailcc { get; set; }
        public string Emailbcc { get; set; }
        public string Emailbody { get; set; }
        public string Description { get; set; }
        public DateTime? SchedTime { get; set; }
        public string ProcGrp { get; set; }
        public int? InstId { get; set; }
        public string Pgpkey { get; set; }
        public string EmailFromName { get; set; }
        public string EmailFromAddress { get; set; }

        public ICollection<Taskreps> Taskreps { get; set; }
    }
}
