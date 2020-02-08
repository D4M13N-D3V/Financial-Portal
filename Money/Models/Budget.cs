using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models
{
    public class Budget
    {
        public Budget()
        {
            BudgetItems = new HashSet<BudgetItem>();
        }

        public int Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
        public int HouseholdId { get; set; }

        public virtual Household Household {get; set;}

        public virtual ICollection<BudgetItem> BudgetItems { get; set; }
    }
}