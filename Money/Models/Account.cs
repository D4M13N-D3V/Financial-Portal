using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int HouseholdId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public float Balance { get; set; }

        public virtual Household Household { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}