using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models
{
    public class Household
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; }

        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}