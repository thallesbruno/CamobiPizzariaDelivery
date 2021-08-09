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
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    //comando.CommandText();
                }
                catch (MySqlException mysqle)
                {
                    throw new System.Exception(mysqle.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
            return listaUsuarios;
        }
    }
}
