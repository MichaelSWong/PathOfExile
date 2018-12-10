using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathOfExile.Models;
using PathOfExile.DAL;
using System.Transactions;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PathOfExile.Tests
{
    [TestClass]
    public class CurrencyModelTests
    {
        private TransactionScope myTransaction;
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PathOfExile;Integrated Security=True";

        CurrencySqlDAL testObj = null;

        [TestInitialize]
        public void Initialize()
        {
            testObj = new CurrencySqlDAL();
            myTransaction = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command;

                connection.Open();

                command = new SqlCommand("INSERT INTO CURRENCY VALUES ('Killer_Orb',5,'Makes everything cool','Killer_Orb_icon.png','1 Killer Orb makes you meta');",connection);
                command.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            myTransaction.Dispose();
        }


        [TestMethod]
        public void GetCurrencyTests()
        {
            CurrencySqlDAL currencyDal = new CurrencySqlDAL();
            List<CurrencyModel> objs = testObj.GetAllCurrency();

            Assert.IsNotNull(objs);
            List<string> name = new List<string>();
            foreach(CurrencyModel obj in objs)
            {
                name.Add(obj.Currency_Name);
            }

            CollectionAssert.Contains(name, "Killer_Orb");
        }
    }
}
