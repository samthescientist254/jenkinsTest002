using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Emailoutbox
    {
        public long Id { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Senddate { get; set; }
        public string Status { get; set; }
        public string Recipient { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Sender { get; set; }
        public string Sendername { get; set; }
        public string ContentType { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Attachments { get; set; }
        public int? Trials { get; set; }
        public string BodySql { get; set; }
        public string AttachmentSql { get; set; }
        public string BodyTemplate { get; set; }
    }
}
