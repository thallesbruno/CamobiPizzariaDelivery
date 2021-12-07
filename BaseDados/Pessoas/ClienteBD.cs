using BaseDados.Modulos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Pessoas
{
    public class ClienteBD
    {
        private readonly FuncoesBD bdFuncoes = new FuncoesBD();
        public List<EntidadeViewPesquisaCliente> ListarPesquisaCliente(Status status, string termoBusca)
        {
            var listaEntidades = new List<EntidadeViewPesquisaCliente>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    string query = @"SELECT codigo, nome, telefone, celular
                                            FROM cliente";
                    if (status != Status.Todos)
                        query += " WHERE SITUACAO = @situacao ";
                    if (!termoBusca.Equals(String.Empty))
                    {
                        if (status == Status.Todos)
                            query += " WHERE";
                        else
                            query += " AND";
                        var termos = termoBusca.Split(' ');
                        foreach (var termo in termos)
                        {
                            query += " nome LIKE '%" + termo + "%' AND";
                        }
                        query = query.Substring(0, query.Length - 3);
                    }

                    comando.CommandText = query;

                    if (status != Status.Todos)
                        comando.Parameters.AddWithValue("situacao", (int)status);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisaCliente();
                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oEntidade.Nome = reader["nome"].ToString();
                        if (reader["telefone"] != null)
                            oEntidade.Telefone = Convert.ToInt64(reader["telefone"]).ToString("(##) ####-####");
                        if (reader["celular"] != null)
                            oEntidade.Celular = Convert.ToInt64(reader["celular"]).ToString("(##) # ####-####");

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

        public Cliente Buscar(int cod)
        {
            var oCliente = new Cliente();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM CLIENTE WHERE codigo = @codigo;";
                    comando.Parameters.AddWithValue("codigo", cod);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        oCliente.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oCliente.Nome = reader["nome"].ToString();
                        if (reader["telefone"] != null)
                        {
                            oCliente.Telefone = Convert.ToInt64(reader["telefone"].ToString());
                        }
                        if (reader["celular"] != null)
                        {
                            oCliente.Celular = Convert.ToInt64(reader["celular"].ToString());
                        }
                        oCliente.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oCliente.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());                        
                        oCliente.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
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
            return oCliente;
        }

        public int BuscarProximoCodigo()
        {
            return bdFuncoes.BuscaCodigo("SHOW TABLE STATUS LIKE 'client'");
        }
    }
}
