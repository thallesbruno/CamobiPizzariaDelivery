using BaseDados.Modulos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Pessoas
{
    public class UsuarioBD
    {
        private readonly FuncoesBD bdFuncoes = new FuncoesBD();

        public bool Inserir(Usuario oUsuario)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"INSERT INTO USUARIO (codigo_tipo_usuario, nome, login, senha, situacao, dt_alteracao, codigo_usr_alteracao)" +
                        " VALUES (@codigo_tipo_usuario, @nome, @login, @senha, @situacao, NOW(), @codigo_usr_alteracao)";
                    comando.Parameters.AddWithValue("codigo_tipo_usuario", oUsuario.TipoUsuario.Codigo);
                    comando.Parameters.AddWithValue("nome", oUsuario.Nome);
                    comando.Parameters.AddWithValue("login", oUsuario.Login);
                    comando.Parameters.AddWithValue("senha", oUsuario.Senha);
                    comando.Parameters.AddWithValue("situacao", (int)oUsuario.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oUsuario.CodigoUsrAlteracao);

                    int valorRetorno = comando.ExecuteNonQuery();
                    if (valorRetorno < 1)
                        isRetorno = false;
                    else
                        isRetorno = true;
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
            return isRetorno;
        }

        public bool Alterar(Usuario oUsuario)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"UPDATE USUARIO SET codigo_tipo_usuario = @codigo_tipo_usuario, nome = @nome, login = @login,
                        senha = @senha, situacao = @situacao, codigo_usr_alteracao = @codigo_usr_alteracao,
                        dt_alteracao = NOW() WHERE codigo = @codigo";

                    comando.Parameters.AddWithValue("codigo_tipo_usuario", oUsuario.TipoUsuario.Codigo);
                    comando.Parameters.AddWithValue("nome", oUsuario.Nome);
                    comando.Parameters.AddWithValue("login", oUsuario.Login);
                    comando.Parameters.AddWithValue("senha", oUsuario.Senha);
                    comando.Parameters.AddWithValue("situacao", (int)oUsuario.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oUsuario.CodigoUsrAlteracao);
                    comando.Parameters.AddWithValue("codigo", oUsuario.Codigo);

                    int valorRetorno = comando.ExecuteNonQuery();
                    if (valorRetorno < 1)
                        isRetorno = false;
                    else
                        isRetorno = true;
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
            return isRetorno;
        }

        public bool Excluir(int codigo)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"DELETE FROM usuario WHERE codigo = @codigo";
                    comando.Parameters.AddWithValue("codigo", codigo);

                    int valorRetorno = comando.ExecuteNonQuery();
                    if (valorRetorno < 1)
                        isRetorno = false;
                    else
                        isRetorno = true;
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
            return isRetorno;
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            var listaEntidades = new List<EntidadeViewPesquisa>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    string query = @"SELECT codigo, nome, login, situacao FROM usuario";
                    if (status != Status.Todos)
                        query += " WHERE situacao = @situacao;";

                    comando.CommandText = query;

                    if (status != Status.Todos)
                        comando.Parameters.AddWithValue("situacao", (int)status);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisa();
                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oEntidade.Descricao = reader["nome"].ToString();
                        oEntidade.Status = (Status)Convert.ToInt16(reader["situacao"]);

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
        public List<Usuario> ListarUsuariosAtivos()
        {
            var listaUsuarios = new List<Usuario>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM USUARIO;";
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oUsuario = new Usuario();
                        oUsuario.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oUsuario.TipoUsuario = new TipoUsuario(Convert.ToInt32(reader["codigo_tipo_usuario"].ToString()), string.Empty);
                        oUsuario.Nome = reader["nome"].ToString();
                        oUsuario.Login = reader["login"].ToString();
                        oUsuario.Senha = reader["senha"].ToString();
                        oUsuario.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oUsuario.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oUsuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());

                        listaUsuarios.Add(oUsuario);
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
            return listaUsuarios;
        }

        public Usuario Buscar(int cod)
        {
            Usuario oUsuario = new Usuario();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM USUARIO WHERE codigo = @codigo;";
                    comando.Parameters.AddWithValue("codigo", cod);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        oUsuario.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oUsuario.TipoUsuario = new TipoUsuario(Convert.ToInt32(reader["codigo_tipo_usuario"].ToString()), string.Empty);
                        oUsuario.Nome = reader["nome"].ToString();
                        oUsuario.Login = reader["login"].ToString();
                        oUsuario.Senha = reader["senha"].ToString();
                        oUsuario.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oUsuario.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oUsuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
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
            return oUsuario;
        }

        public int BuscarProximoCodigo()
        {
            return bdFuncoes.BuscaCodigo("SHOW TABLE STATUS LIKE 'usuario'");
        }
    }
}
