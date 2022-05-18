using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Pessoas
{
    public class TipoUsuarioBD
    {
        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa()
        {
            var listaEntidades = new List<EntidadeViewPesquisa>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    string query = @"SELECT codigo, descricao FROM tipo_usuario";

                    comando.CommandText = query;

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisa();
                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oEntidade.Descricao = reader["descricao"].ToString();
                        //oEntidade.Status = (Status)Convert.ToInt16(reader["situacao"]);

                        listaEntidades.Add(oEntidade);
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
            return listaEntidades;
        }
        public TipoUsuario BuscarTipoUsuarioDoUsuario(int codigo)
        {
            TipoUsuario tipoUsuario = null;
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
                        tipoUsuario = new TipoUsuario();
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

        public TipoUsuario Buscar(int codigo)
        {
            TipoUsuario tipoUsuario = null;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"SELECT * FROM tipo_usuario WHERE CODIGO = @codigo";
                    comando.Parameters.AddWithValue("codigo", codigo);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        tipoUsuario = new TipoUsuario();
                        tipoUsuario.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        tipoUsuario.Descricao = reader["descricao"].ToString();
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
