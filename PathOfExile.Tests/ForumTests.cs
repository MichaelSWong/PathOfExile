using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathOfExile.Models;
using PathOfExile.DAL;
using System.Transactions;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PathOfExile.Tests
{
    [TestClass]
    public class ForumTests
    {
        private TransactionScope myTransaction;
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PathOfExile;Integrated Security=True";

        ForumPostSqlDAL testObj = null;

        [TestInitialize]
        public void Initialize()
        {
            testObj = new ForumPostSqlDAL();
            myTransaction = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command;

                connection.Open();

                command = new SqlCommand("INSERT INTO Forum_Post VALUES('dude','Betrayed','Betrayal is so fun!', GETDATE());", connection);
                command.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            myTransaction.Dispose();
        }

        [TestMethod]
        public void ForumPostTest()
        {
            ForumPostSqlDAL forumPostDal = new ForumPostSqlDAL();
            List<ForumPostModel> objs = testObj.GetAllPosts();

            Assert.IsNotNull(objs);
            List<string> name = new List<string>();
            foreach (ForumPostModel obj in objs)
            {
                name.Add(obj.UserName);
            }

            CollectionAssert.Contains(name, "dude");



        }
    }
}
