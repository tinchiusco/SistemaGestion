using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionMuebles.Database
{
    internal static class DatabaseConnection
    {
        private static readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True";

        public static SqlConnection GetConnection() {

            return new SqlConnection(connectionString);
        }
        
        
    }
        
}
