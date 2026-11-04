using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ProiectEAV_Muzee
{
   
    public static class DBHelper
    {
      
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestiuneMuzee;Integrated Security=True";

       
        public static async Task<DataTable> GetDataAsync(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);

                    DataTable dt = new DataTable(); 
                    await conn.OpenAsync(); 

                    
                    using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(dr);
                    }
                    return dt; 
                }
            }
        }

        public static async Task ExecuteQueryAsync(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    if (parameters != null) cmd.Parameters.AddRange(parameters);

                    await conn.OpenAsync();
                   
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}