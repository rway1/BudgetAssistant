using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BudgetAssistant;
using System.IO;

namespace BudgetAssistantTest
{
    [TestClass]
    public class TransactionTest
    {
        static Transaction transaction;
        

        [TestMethod]
        public void TransactionConstructorTest()
        {
            transaction = new Transaction("08/15/2018,870.17,*,,ONLINE PAYMENT");
            Assert.IsTrue(transaction.Date == new DateTime(2018, 8, 15));
            Assert.IsTrue(transaction.Amount == 870.17);
            Assert.IsTrue(transaction.Location == "ONLINE PAYMENT");
        }
    }
}
