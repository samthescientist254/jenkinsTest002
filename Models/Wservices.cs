using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Wservices
    {
        public short Id { get; set; }
        public string CfgMonitorMachineName { get; set; }
        public string CfgMachineName { get; set; }
        public string CfgServiceName { get; set; }
        public string CfgEmailIfDown { get; set; }
        public bool? CfgActive { get; set; }
        public bool? CfgShowWeb { get; set; }
        public string CfgProcessImageName { get; set; }
        public int? StsLastStatus { get; set; }
        public DateTime? StsLastCheck { get; set; }
        public int? StsEmailsSent { get; set; }
        public string StsLastStatusCheckError { get; set; }
        public string StsLastCheckMachineName { get; set; }
        public string StsUserComment { get; set; }
    }
}
