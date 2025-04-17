using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class DataTransferPackageVariables
    {
        public long Id { get; set; }
        public string Varname { get; set; }
        public string Varvalue { get; set; }
        public DateTime? Currtime { get; set; }
        public string Pkg { get; set; }
        public int? ShclogCnt { get; set; }
        public int? ShclogNonPptCnt { get; set; }
        public int? Completed { get; set; }
    }
}
