using MySql.Data.MySqlClient;
using System.Configuration;

namespace BaseDados
{
    public class ConexaoBaseDados
    {
        private static readonly ConexaoBaseDados instanciaMySQL = new ConexaoBaseDados();

        public static ConexaoBaseDados getInstancia()
        {
            return instanciaMySQL;
        }

        public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            return new MySqlConnection(conn);
        }
    }
}
