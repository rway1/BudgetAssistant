using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAssistant
{

    public class Sorted_Transaction : Transaction
    {
        public enum Categories
        {
            Necesities,
            Utilities,
            Groceries,
            Gas,
            Car,
            Fun,
            Stuff,
            Vacation,
            Date,
            Savings,
        }

        private Categories _category;

        public Categories Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public Sorted_Transaction(double amount, DateTime dateTime, string location, Categories category)
            : base(amount, dateTime, location)
        {
            Category = category;
        }

    }
}
