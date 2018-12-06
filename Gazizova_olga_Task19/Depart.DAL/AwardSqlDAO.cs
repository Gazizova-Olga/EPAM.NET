using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Entities;

namespace Depart.DAL
{
    public class AwardSqlDAO : IAwardDAO
    {

        string connectionString = "Data Source=AUREN-ПК\\stud;Initial Catalog=Users_and_awards;Integrated Security=True";
        // public AwardSqlDAO() { ConfigurationManager.AppSettings}

        public void Add(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("sp_AddAward"))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@name", award.Name);
                    command.Parameters.AddWithValue("@description", award.Description);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("sp_AlterAward");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", award.Id);
                command.Parameters.AddWithValue("@name", award.Name);
                command.Parameters.AddWithValue("@desc", award.Description);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Award> GetList()
        {
            List<Award> awards = new List<Award>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT Id, Name, Description FROM Awards");
                command.Connection = connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["name"];
                    string description = (string)reader["description"];

                    awards.Add(new Award(id, name, description));
                }
                reader.Close();
                return awards;
            }
        }

        public void Remove(Award award)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("sp_DeleteAward");
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@AwardId", award.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}