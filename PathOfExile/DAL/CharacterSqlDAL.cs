using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PathOfExile.Models;
using System.Data.SqlClient;

namespace PathOfExile.DAL
{
    public class CharacterSqlDAL
    {
        const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PathOfExile;Integrated Security=True";

        public List<CharacterModel> GetAllCharacters()
        {
            List<CharacterModel> output = new List<CharacterModel>();

            string SQL_GetCommand = "SELECT * FROM Classes";// JOIN Ascendancy ON Ascendancy.classes_id=Classes.classes_id";


            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand(SQL_GetCommand, myConnection);

                    myConnection.Open();

                    SqlDataReader myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        CharacterModel temp = new CharacterModel()
                        {
                            Classes_Id = Convert.ToInt32(myReader["classes_id"]),
                            Classes_Name = Convert.ToString(myReader["classes_name"]),
                            Starting_Str = Convert.ToInt32(myReader["starting_str"]),
                            Starting_Dex = Convert.ToInt32(myReader["starting_dex"]),
                            Starting_Int = Convert.ToInt32(myReader["starting_int"]),
                            Classes_Image = Convert.ToString(myReader["classes_image"]),
                            //Ascendancy_Id = Convert.ToInt32(myReader["ascendancy_id"]),
                            //Ascendancy_Name = Convert.ToString(myReader["ascendancy_name"]),
                            //Ascendancy_Image = Convert.ToString(myReader["ascendancy_image"])
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
        public List<CharacterModel> GetAllClasses()
        {
            List<CharacterModel> output = new List<CharacterModel>();

            string SQL_GetCommand = "SELECT * FROM Classes;";


            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand(SQL_GetCommand, myConnection);

                    myConnection.Open();

                    SqlDataReader myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        CharacterModel temp = new CharacterModel()
                        {
                            Classes_Id = Convert.ToInt32(myReader["classes_id"]),
                            Classes_Name = Convert.ToString(myReader["classes_name"]),
                            Starting_Str = Convert.ToInt32(myReader["starting_str"]),
                            Starting_Dex = Convert.ToInt32(myReader["starting_dex"]),
                            Starting_Int = Convert.ToInt32(myReader["starting_int"]),
                            Classes_Image = Convert.ToString(myReader["classes_image"]),                            
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


        public CharacterModel GetCharacter(int id)
        {
            return GetAllCharacters().FirstOrDefault(c => c.Classes_Id == id);
        }
    }
}
