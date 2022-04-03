using BaseDados.Modulos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Produtos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Produtos
{
    public class TamanhoPizzaBD
    {
        private readonly FuncoesBD bdFuncoes = new FuncoesBD();

        public bool Inserir(TamanhoPizza oTamanhoPizza)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"INSERT INTO tamanho_pizza
                                          (descricao,
                                           observacao,
                                           valor,
                                           qtd_sabores,
                                           situacao,
                                           dt_alteracao,
                                           codigo_usr_alteracao)
                                        VALUES
                                          (@descricao,
                                           @observacao,
                                           @valor,
                                           @qtd_sabores,
                                           @situacao,
                                           NOW(),
                                           @codigo_usr_alteracao)
                                        ";
                    comando.Parameters.AddWithValue("descricao", oTamanhoPizza.Descricao);
                    comando.Parameters.AddWithValue("observacao", oTamanhoPizza.Observacao);
                    comando.Parameters.AddWithValue("valor", oTamanhoPizza.Valor);
                    comando.Parameters.AddWithValue("qtd_sabores", oTamanhoPizza.QtdSabores);
                    comando.Parameters.AddWithValue("situacao", (int)oTamanhoPizza.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oTamanhoPizza.CodigoUsrAlteracao);

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

        public bool Alterar(TamanhoPizza oTamanhoPizza)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"UPDATE tamanho_pizza
                                            SET descricao            = @descricao,
                                                observacao           = @observacao,
                                                valor                = @valor,
                                                qtd_sabores          = @qtd_sabores,
                                                situacao             = @situacao,
                                                dt_alteracao         = NOW(),
                                                codigo_usr_alteracao = @codigo_usr_alteracao
                                            WHERE codigo = @codigo
                                        ";
                    comando.Parameters.AddWithValue("descricao", oTamanhoPizza.Descricao);
                    comando.Parameters.AddWithValue("observacao", oTamanhoPizza.Observacao);
                    comando.Parameters.AddWithValue("valor", oTamanhoPizza.Valor);
                    comando.Parameters.AddWithValue("qtd_sabores", oTamanhoPizza.QtdSabores);
                    comando.Parameters.AddWithValue("situacao", (int)oTamanhoPizza.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oTamanhoPizza.CodigoUsrAlteracao);
                    comando.Parameters.AddWithValue("codigo", oTamanhoPizza.Codigo);

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

                    comando.CommandText = @"DELETE FROM tamanho_pizza WHERE codigo = @codigo";
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
                                            FROM tamanho_pizza";
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

        public List<TamanhoPizza> ListarTamanhoDePizzaAtivos()
        {
            var listaTamanhoDePizza = new List<TamanhoPizza>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM tamanho_pizza WHERE situacao = 1;";
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oTamanhoPizza = new TamanhoPizza();
                        oTamanhoPizza.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oTamanhoPizza.Descricao = reader["descricao"].ToString();
                        if (!(reader["observacao"] is System.DBNull))
                            oTamanhoPizza.Observacao = reader["observacao"].ToString();
                        oTamanhoPizza.Valor = Convert.ToDecimal(reader["valor"].ToString());
                        oTamanhoPizza.QtdSabores = Convert.ToInt32(reader["qtd_sabores"].ToString());
                        oTamanhoPizza.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oTamanhoPizza.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oTamanhoPizza.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());

                        listaTamanhoDePizza.Add(oTamanhoPizza);
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
            return listaTamanhoDePizza;
        }

        public TamanhoPizza Buscar(int cod)
        {
            TamanhoPizza oTamanhoPizza = new TamanhoPizza();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM tamanho_pizza WHERE codigo = @codigo;";
                    comando.Parameters.AddWithValue("codigo", cod);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        oTamanhoPizza.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oTamanhoPizza.Descricao = reader["descricao"].ToString();
                        if (!(reader["observacao"] is System.DBNull))
                            oTamanhoPizza.Observacao = reader["observacao"].ToString();
                        oTamanhoPizza.Valor = Convert.ToDecimal(reader["valor"].ToString());
                        oTamanhoPizza.QtdSabores = Convert.ToInt32(reader["qtd_sabores"].ToString());                        
                        oTamanhoPizza.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oTamanhoPizza.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oTamanhoPizza.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
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
            return oTamanhoPizza;
        }

        public int BuscarProximoCodigo()
        {
            return bdFuncoes.BuscaCodigo("SHOW TABLE STATUS LIKE 'tamanho_pizza'");
        }
    }
}
