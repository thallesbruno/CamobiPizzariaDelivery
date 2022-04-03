using BaseDados.Modulos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Produtos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Produtos
{
    public class SaborBordaBD
    {
        private readonly FuncoesBD bdFuncoes = new FuncoesBD();

        public bool Inserir(SaborBorda oSaborBorda)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"INSERT INTO sabor_borda
                                          (descricao,
                                           observacao,
                                           valor_adicional,
                                           situacao,
                                           dt_alteracao,
                                           codigo_usr_alteracao)
                                        VALUES
                                          (@descricao,
                                           @observacao,
                                           @valor_adicional,
                                           @situacao,
                                           NOW(),
                                           @codigo_usr_alteracao)
                                        ";
                    comando.Parameters.AddWithValue("descricao", oSaborBorda.Descricao);
                    comando.Parameters.AddWithValue("observacao", oSaborBorda.Observacao);
                    comando.Parameters.AddWithValue("valor_adicional", oSaborBorda.ValorAdicional);
                    comando.Parameters.AddWithValue("situacao", (int)oSaborBorda.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oSaborBorda.CodigoUsrAlteracao);

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

        public bool Alterar(SaborBorda oSaborBorda)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"UPDATE sabor_borda
                                            SET descricao            = @descricao,
                                                observacao           = @observacao,
                                                valor_adicional      = @valor_adicional,
                                                situacao             = @situacao,
                                                dt_alteracao         = NOW(),
                                                codigo_usr_alteracao = @codigo_usr_alteracao
                                            WHERE codigo = @codigo
                                        ";
                    comando.Parameters.AddWithValue("descricao", oSaborBorda.Descricao);
                    comando.Parameters.AddWithValue("observacao", oSaborBorda.Observacao);
                    comando.Parameters.AddWithValue("valor_adicional", oSaborBorda.ValorAdicional);
                    comando.Parameters.AddWithValue("situacao", (int)oSaborBorda.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oSaborBorda.CodigoUsrAlteracao);
                    comando.Parameters.AddWithValue("codigo", oSaborBorda.Codigo);

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

                    comando.CommandText = @"DELETE FROM sabor_borda WHERE codigo = @codigo";
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

                    string query = @"SELECT codigo, descricao, situacao
                                            FROM sabor_borda";
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
                        oEntidade.Descricao = reader["descricao"].ToString();
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

        public List<SaborBorda> ListarSaboresDeBordaAtivos()
        {
            var listaSaboresDeBorda = new List<SaborBorda>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM sabor_borda WHERE situacao = 1;";
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oSaborBorda = new SaborBorda();
                        oSaborBorda.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oSaborBorda.Descricao = reader["descricao"].ToString();
                        if (!(reader["observacao"] is System.DBNull))
                            oSaborBorda.Observacao = reader["observacao"].ToString();
                        oSaborBorda.ValorAdicional = Convert.ToDecimal(reader["valor_adicional"].ToString());
                        oSaborBorda.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oSaborBorda.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oSaborBorda.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());

                        listaSaboresDeBorda.Add(oSaborBorda);
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
            return listaSaboresDeBorda;
        }

        public SaborBorda Buscar(int cod)
        {
            SaborBorda oSaborBorda = new SaborBorda();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM sabor_borda WHERE codigo = @codigo;";
                    comando.Parameters.AddWithValue("codigo", cod);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        oSaborBorda.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oSaborBorda.Descricao = reader["descricao"].ToString();
                        if (!(reader["observacao"] is System.DBNull))
                            oSaborBorda.Observacao = reader["observacao"].ToString();
                        oSaborBorda.ValorAdicional = Convert.ToDecimal(reader["valor_adicional"].ToString());
                        oSaborBorda.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oSaborBorda.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oSaborBorda.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
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
            return oSaborBorda;
        }

        public int BuscarProximoCodigo()
        {
            return bdFuncoes.BuscaCodigo("SHOW TABLE STATUS LIKE 'sabor_borda'");
        }
    }
}
