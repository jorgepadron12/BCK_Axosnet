
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BCK_Axosnet
{
    public class Conexion : DbContext
    {
        public readonly string _connectionString;
        public Conexion(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Produccion");
        }
    }    
}