using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
    public class Applications
    {
        [XmlElement(ElementName = "application")]
        public List<Application> application { get; set; }
    }
}
