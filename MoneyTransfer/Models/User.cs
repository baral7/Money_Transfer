using System;
using System.Collections.Generic;

namespace MoneyTransfer.Models
{
    public partial class User
    {
        public User()
        {
            BankDetails = new HashSet<BankDetail>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Status { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<BankDetail> BankDetails { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
