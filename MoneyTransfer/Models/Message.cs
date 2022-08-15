using System;
using System.Collections.Generic;

namespace MoneyTransfer.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string? Bank { get; set; }
        public int? Amount { get; set; }
        public string? Date { get; set; }
        public string? DocumentPath { get; set; }
    }
}
