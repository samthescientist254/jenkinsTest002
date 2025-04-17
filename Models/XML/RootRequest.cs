using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    public class RootRequest
    {
        [XmlElement(ElementName = "bridge",Namespace = "http://CTL.COM.SERVICES.BRIDGE.DataEntities")]
        public Bridge bridge { get; set; }
    }
}
