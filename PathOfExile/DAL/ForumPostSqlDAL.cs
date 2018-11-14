using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PathOfExile.Models;
using System.Data.SqlClient;

namespace PathOfExile.DAL
{
    public class ForumPostSqlDAL
    {
        const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PathOfExile;Integrated Security=True";

        public List<ForumPostModel> GetAllPosts()
        {
            List<ForumPostModel> output = new List<ForumPostModel>();

            string SQL_GetCommand = "SELECT * FROM forum_post order by post_date desc";

            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand(SQL_GetCommand, myConnection);

                    myConnection.Open();

                    SqlDataReader myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        ForumPostModel temp = new ForumPostModel()
                        {
                            Forum_Id = Convert.ToInt32(myReader["forum_id"]),
                            UserName = Convert.ToString(myReader["username"]),
                            Subject = Convert.ToString(myReader["subject"]),
                            Message = Convert.ToString(myReader["message"]),
                            PostDate = Convert.ToDateTime(myReader["post_date"])
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

        public bool SaveNewPost(ForumPostModel post)
        {
            string SQL_InsertCommand = "INSERT INTO forum_post (username, subject, message) VALUES(@username, @subject, @message);";

            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand(SQL_InsertCommand, myConnection);
                    myCommand.Parameters.AddWithValue("@username", post.UserName);
                    myCommand.Parameters.AddWithValue("@subject", post.Subject);
                    myCommand.Parameters.AddWithValue("@message", post.Message);

                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
            return true;
        }
    }
}
