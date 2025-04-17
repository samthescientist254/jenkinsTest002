using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
   /* [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]*/
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
 /*   [System.ComponentModel.DesignerCategoryAttribute("code")]*/
    [XmlRoot(elementName: "bridge",Namespace = "http://CTL.COM.SERVICES.BRIDGE.DataEntities")]
     
    public class Bridge
    {
        [XmlElement(ElementName = "applications")]
        public Applications applications { get; set; }
    }
}
