﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    public class RiskDomains
    {
        [XmlElement("riskDomain")]
        public RiskDomain riskDomain { get; set; }
    }
}
