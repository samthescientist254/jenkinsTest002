using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransactionDataApiSettlement.Models.XML
{
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public class RiskDomain
    {
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string groupNumber { get; set; }
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string authCurrency { get; set; }

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string authLimit { get; set; }

	}
}
