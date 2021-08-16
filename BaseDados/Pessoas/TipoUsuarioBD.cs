using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;

namespace BaseDados.Pessoas
{
    public class TipoUsuarioBD
    {
        public TipoUsuario BuscarTipoUsuarioDoUsuario(int codigo)
        {
            TipoUsuario tipoUsuario = new TipoUsuario();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"SELECT
                                            U.CODIGO_TIPO_USUARIO AS CodigoTipoUsuario,
                                            TU.DESCRICAO AS DescricaoTipoUsuario
                                            FROM USUARIO AS U
                                            INNER JOIN TIPO_USUARIO AS TU ON U.CODIGO_TIPO_USUARIO = TU.CODIGO
                                            WHERE U.CODIGO = @codigo";
                    comando.Parameters.AddWithValue("codigo", codigo);
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        tipoUsuario.Codigo = Convert.ToInt32(reader["CodigoTipoUsuario"].ToString());
                        tipoUsuario.Descricao = reader["DescricaoTipoUsuario"].ToString();
                    }
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
            return tipoUsuario;
        }
    }
}
