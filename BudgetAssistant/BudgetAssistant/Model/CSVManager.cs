using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAssistant
{
    public class CSVManager
    {
        public const string PATH_TO_TRANSACTIONS_FILE = @"C:\Users\ryank\OneDrive\Desktop\8_12-8_18Transactions.csv";
        public const string PATH_TO_DEDUCTIONS_FILE = @"C:\Users\ryank\OneDrive\Desktop\FinanceLog3.0 - Deductions3.0.csv";

        public CSVManager()
        {
            ParseTransactions();
        }

        public List<Transaction> ParseTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            foreach (var item in System.IO.File.ReadAllLines(PATH_TO_TRANSACTIONS_FILE))
            {
                transactions.Add(new Transaction(item.Replace("\"", "").Replace(" ", "")));
            }
            return transactions;
        }
    }
}
