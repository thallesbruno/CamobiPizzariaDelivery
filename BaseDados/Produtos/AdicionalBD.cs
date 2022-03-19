using BaseDados.Modulos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Produtos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Produtos
{
    public class AdicionalBD
    {
        private readonly FuncoesBD bdFuncoes = new FuncoesBD();

        public bool Inserir(Adicional oAdicional)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"INSERT INTO adicional (descricao, observacao, valor, situacao, dt_alteracao, codigo_usr_alteracao)" +
                        " VALUES (@descricao, @observacao, @valor, @situacao, NOW(), @codigo_usr_alteracao)";
                    comando.Parameters.AddWithValue("descricao", oAdicional.Descricao);
                    comando.Parameters.AddWithValue("observacao", oAdicional.Observacao);
                    comando.Parameters.AddWithValue("valor", oAdicional.Valor);
                    comando.Parameters.AddWithValue("situacao", (int)oAdicional.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oAdicional.CodigoUsrAlteracao);

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

        //public bool Alterar(Usuario oUsuario)
        //{
        //    bool isRetorno = false;
        //    using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
        //    {
        //        try
        //        {
        //            conexao.Open();
        //            MySqlCommand comando = new MySqlCommand();
        //            comando = conexao.CreateCommand();

        //            comando.CommandText = @"UPDATE USUARIO SET codigo_tipo_usuario = , nome = @nome, login = @login,
        //                senha = @senha, situacao = @situacao, codigo_usr_alteracao = @codigo_usr_alteracao,
        //                dt_alteracao = NOW() WHERE codigo = @codigo";

        //            comando.Parameters.AddWithValue("codigo_tipo_usuario", oUsuario.TipoUsuario.Codigo);
        //            comando.Parameters.AddWithValue("nome", oUsuario.Nome);
        //            comando.Parameters.AddWithValue("login", oUsuario.Login);
        //            comando.Parameters.AddWithValue("senha", oUsuario.Senha);
        //            comando.Parameters.AddWithValue("situacao", (int)oUsuario.Status);
        //            comando.Parameters.AddWithValue("codigo_usr_alteracao", oUsuario.CodigoUsrAlteracao);
        //            comando.Parameters.AddWithValue("codigo", oUsuario.Codigo);

        //            int valorRetorno = comando.ExecuteNonQuery();
        //            if (valorRetorno < 1)
        //                isRetorno = false;
        //            else
        //                isRetorno = true;
        //        }
        //        catch (MySqlException mysqle)
        //        {
        //            throw new System.Exception(mysqle.ToString());
        //        }
        //        finally
        //        {
        //            conexao.Close();
        //        }
        //    }
        //    return isRetorno;
        //}

        //public bool Excluir(int codigo)
        //{
        //    bool isRetorno = false;
        //    using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
        //    {
        //        try
        //        {
        //            conexao.Open();
        //            MySqlCommand comando = new MySqlCommand();
        //            comando = conexao.CreateCommand();

        //            comando.CommandText = @"DELETE FROM usuario WHERE codigo = @codigo";
        //            comando.Parameters.AddWithValue("codigo", codigo);

        //            int valorRetorno = comando.ExecuteNonQuery();
        //            if (valorRetorno < 1)
        //                isRetorno = false;
        //            else
        //                isRetorno = true;
        //        }
        //        catch (MySqlException mysqle)
        //        {
        //            throw new System.Exception(mysqle.ToString());
        //        }
        //        finally
        //        {
        //            conexao.Close();
        //        }
        //    }
        //    return isRetorno;
        //}

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

                    string query = @"SELECT codigo, descricao, situacao
                                            FROM adicional";
                    if (status != Status.Todos)
                        query += " WHERE SITUACAO = @situacao; ";

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

        public List<Adicional> ListarAdicionaisAtivos()
        {
            var listaAdicionais = new List<Adicional>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM adicional WHERE situacao = 1;";
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oAdicional = new Adicional();
                        oAdicional.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oAdicional.Descricao = reader["nome"].ToString();
                        if(!(reader["observacao"] is System.DBNull))
                            oAdicional.Observacao = reader["observacao"].ToString();
                        oAdicional.Valor = Convert.ToDecimal(reader["valor"].ToString());
                        oAdicional.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oAdicional.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oAdicional.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());

                        listaAdicionais.Add(oAdicional);
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
            return listaAdicionais;
        }

        public Adicional Buscar(int cod)
        {
            Adicional oAdicional = new Adicional();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM adicional WHERE codigo = @codigo;";
                    comando.Parameters.AddWithValue("codigo", cod);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        oAdicional.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oAdicional.Descricao = reader["nome"].ToString();
                        if (!(reader["observacao"] is System.DBNull))
                            oAdicional.Observacao = reader["observacao"].ToString();
                        oAdicional.Valor = Convert.ToDecimal(reader["valor"].ToString());
                        oAdicional.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oAdicional.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oAdicional.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
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
            return oAdicional;
        }

        public int BuscarProximoCodigo()
        {
            return bdFuncoes.BuscaCodigo("SHOW TABLE STATUS LIKE 'adicional'");
        }
    }
}
