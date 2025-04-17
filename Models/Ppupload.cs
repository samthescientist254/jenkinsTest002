using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Ppupload
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string Sqlselect { get; set; }
        public string ProcGrp { get; set; }
    }
}
