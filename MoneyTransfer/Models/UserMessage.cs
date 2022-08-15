using System;
using System.Collections.Generic;

namespace MoneyTransfer.Models
{
    public partial class UserMessage
    {
        public int? UserId { get; set; }
        public int? MessageId { get; set; }

        public virtual Message? Message { get; set; }
        public virtual User? User { get; set; }
    }
}
