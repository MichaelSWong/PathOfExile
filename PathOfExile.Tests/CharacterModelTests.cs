using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathOfExile.Models;
using PathOfExile.DAL;
using System.Transactions;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PathOfExile.Tests
{
    [TestClass]
    public class CharacterModelTests
    {
        private TransactionScope myTransaction;
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PathOfExile;Integrated Security=True";

        CharacterSqlDAL testObj = null;

        [TestInitialize]
        public void Initialize()
        {
            testObj = new CharacterSqlDAL();
            myTransaction = new TransactionScope();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command;

                connection.Open();

                command = new SqlCommand("INSERT INTO CLASSES VALUES('Killer',22,22,27,'Killer_avatar.png');", connection);
                command.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            myTransaction.Dispose();
        }


        [TestMethod]
        public void GetCharacterModelsTest()
        {
            // ARRANGE
            CharacterSqlDAL characterDal = new CharacterSqlDAL();
            List<CharacterModel> objs = testObj.GetAllCharacters();

            // ACT
            Assert.IsNotNull(objs);
            List<string> name = new List<string>();
            foreach(CharacterModel obj in objs)
            {
                name.Add(obj.Classes_Name);
            }

            // ASSERT
            CollectionAssert.Contains(name, "Killer");
        }
    }
}
