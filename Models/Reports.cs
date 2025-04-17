using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Reports
    {
        public Reports()
        {
            Taskreps = new HashSet<Taskreps>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Filename { get; set; }
        public string Description { get; set; }
        public bool ShowWeb { get; set; }
        public string Targetdbid { get; set; }

        public ICollection<Taskreps> Taskreps { get; set; }
    }
}
