using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class LocationMaps
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string Target { get; set; }
        public string Description { get; set; }
        public int Kilobytes { get; set; }
    }
}
