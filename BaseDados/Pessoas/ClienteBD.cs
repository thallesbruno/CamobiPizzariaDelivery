using Entidades.Entidades;
using Entidades.Enumeradores;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Pessoas
{
    public class ClienteBD
    {
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

                    string query = @"SELECT codigo, nome, telefone, celular AS descricao, situacao
                                            FROM USUARIO";
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
    }
}
