using ConsoleApp1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    public class TimeSqlServerRepository : ITimeRepository
    {
        SqlConnection connection = null;

        public TimeSqlServerRepository(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public void Add(Time time)
        {
            string query = $"INSERT INTO Time ( Name) VALUES ('{time.Nome}')";
            SqlCommand command = GetCommand(query);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }



        public void Delete(Time time)
        {
            throw new NotImplementedException();
        }

        public List<Time> Get()
        {
            List<Time> times = new List<Time>();

            string query = $"SELECT ID, Name FROM Time";
            SqlCommand command = GetCommand(query);

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["Id"];
                string nome = reader["Name"].ToString();

                Time time = new Time()
                {
                    Id = id,
                    Nome = nome
                };

                times.Add(time);
            }

            connection.Close();

            return times;
        }

        public Time Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Time time)
        {
            throw new NotImplementedException();
        }

        private SqlCommand GetCommand(string query)
        {
            return new SqlCommand(query, connection);
        }
    }
}
