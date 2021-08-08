using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BaseDados.Pessoas
{
    public class UsuarioBD
    {
        public List<Usuario> ListarUsuarios()
        {
            var listaUsuarios = new List<Usuario>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {

            }
            return listaUsuarios;
        }
    }
}
