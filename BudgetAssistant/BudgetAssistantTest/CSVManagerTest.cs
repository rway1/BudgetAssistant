using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BudgetAssistant;
using System.IO;

namespace BudgetAssistantTest
{
    [TestClass]
    public class CSVManagerTest
    {
        static CSVManager csvManager = new CSVManager();

        public void FileTesterHelper(string fileName)
        {
            Assert.IsTrue(File.Exists(fileName));
            bool bCanBeOpened = false;
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                bCanBeOpened = true;
            }
            Assert.IsTrue(bCanBeOpened);
        }

        [TestMethod]
        public void OpenDeductionsFileTest()
        {
            FileTesterHelper(CSVManager.PATH_TO_DEDUCTIONS_FILE);
        }

        [TestMethod]
        public void OpenTransactionsFileTest()
        {
            FileTesterHelper(CSVManager.PATH_TO_TRANSACTIONS_FILE);
        }
    }
}
