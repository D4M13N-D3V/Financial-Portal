using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        [StringLength(80)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        [StringLength(15)]
        public string Category { get; set; }
        public int BudgetItemId { get; set; }
        public string SubmitterId { get; set; }


        //Virtual Navigation.
        public virtual Account Account { get; set; }
        public virtual BudgetItem BudgetItem { get; set; }
        public virtual ApplicationUser Submitter { get; set; }

    }
}