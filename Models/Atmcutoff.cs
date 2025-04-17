using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Atmcutoff
    {
        public int Rptgrp { get; set; }
        public string Termid { get; set; }
        public int? Cutoff { get; set; }
    }
}
