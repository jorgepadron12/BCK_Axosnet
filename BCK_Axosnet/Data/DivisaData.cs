using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCK_Axosnet.Model;
using Microsoft.Data.SqlClient;

namespace BCK_Axosnet.Data
{
    public class DivisaData
    {
        Conexion _conexion;

        
        public async Task<String> GetAll()
        {

            using (SqlConnection sql = new SqlConnection(_conexion._connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spc_Divisas", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@Id", Id));
                    String response = null;
                    await sql.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine(reader);
                            //response = MapToValue(reader);
                        }
                    }
                    return response;
                }
            }
        }

        public Task<DivisaModel> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int Id)
        {
            throw new NotImplementedException();
        }
    }

}
