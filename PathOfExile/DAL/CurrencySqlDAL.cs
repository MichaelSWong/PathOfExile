using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PathOfExile.Models;
using System.Data.SqlClient;

namespace PathOfExile.DAL
{
    public class CurrencySqlDAL
    {
        const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PathOfExile;Integrated Security=True";

        public List<CurrencyModel> GetAllCurrency()
        {
            List<CurrencyModel> output = new List<CurrencyModel>();

            string SQL_GetCommand = "SELECT * FROM Currency";

            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand(SQL_GetCommand, myConnection);

                    myConnection.Open();

                    SqlDataReader myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        CurrencyModel temp = new CurrencyModel()
                        {
                            Currency_Id = Convert.ToInt32(myReader["currency_id"]),
                            Currency_Name = Convert.ToString(myReader["currency_name"]),
                            Stack_Size = Convert.ToInt32(myReader["stack_size"]),
                            Description_Text = Convert.ToString(myReader["description_text"]),
                            Currency_Image = Convert.ToString(myReader["currency_image"]),                            
                        };
                        output.Add(temp);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return output;
        }
    }
}
