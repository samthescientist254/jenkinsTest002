using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int Code { get; set; }
        public string Url { get; set; }
        public string Target { get; set; }
        public int Pos { get; set; }
        public string Status { get; set; }
    }
}
