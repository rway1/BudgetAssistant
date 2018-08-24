using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAssistant
{

    public class Transaction
    {
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private double _amount;

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public Transaction(string csv_transaction)
        {
            string[] data = csv_transaction.Split(',');
            Date = DateTime.Parse(data[0]);

            Amount = double.Parse(data[1]);

            Location = data[4];
        }

    }
}
