using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetAssistant;

namespace TransactionSortConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVManager cSVManager = new CSVManager();
            List<Transaction> transactions = cSVManager.ParseTransactions();
            PrintPrompt();
            Console.WriteLine();
            PrintTransactions(transactions);
            Console.ReadLine();
        }

        private static void PrintTransactions(List<Transaction> transactions)
        {
            Console.WriteLine(string.Format("{0,10}\t{1,30}", "Amount", "Location"));
            foreach (var item in transactions)
            {
                Console.WriteLine(string.Format("{0,10}\t{1,30}", item.Amount, item.Location));
            }
        }

        public static void PrintPrompt()
        {
            foreach (var item in Enum.GetValues(typeof(Sorted_Transaction.Categories)))
            {
                Console.WriteLine(string.Format("{0} {1}", Convert.ToInt32(item), item.ToString()));
            }
        }
    }
}
