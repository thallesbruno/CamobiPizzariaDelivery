using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Pessoas
{
    public class EnderecoClienteBD
    {
        public List<Endereco> BuscarEnderecosCliente(int codCliente)
        {
            List<Endereco> lista = new List<Endereco>();

            int codEnderecoPadrao = new EnderecoPadraoClienteBD().BuscarEnderecoPadraoCliente(codCliente);

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM endereco_cliente WHERE codigo_cliente = @codigo_cliente;";
                    comando.Parameters.AddWithValue("codigo_cliente", codCliente);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oEndereco = new Endereco();
                        oEndereco.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        if (oEndereco.Codigo == codEnderecoPadrao)
                            oEndereco.IsEnderecoPadrao = true;
                        else
                            oEndereco.IsEnderecoPadrao = false;

                        oEndereco.CodigoCliente = Convert.ToInt32(reader["codigo_cliente"].ToString());
                        oEndereco.Rua = reader["rua"].ToString();
                        oEndereco.Numero = Convert.ToInt32(reader["numero"].ToString());
                        if (reader["complemento"] != DBNull.Value)
                            oEndereco.Complemento = reader["complemento"].ToString();
                        oEndereco.Bairro = reader["bairro"].ToString();
                        oEndereco.Cidade = reader["cidade"].ToString();
                        lista.Add(oEndereco);
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
            return lista;
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(int codCliente)
        {
            var listaEntidades = new List<EntidadeViewPesquisa>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    string query = @"select codigo, concat(rua,
				                    ', nº ',
                                    numero,
                                    if(complemento like null, null, concat(', ', complemento)),
                                    ', ', bairro,
                                    ', ', cidade
                                    ) as descricao, '1' as situacao
                                    FROM pizzarias.endereco_cliente
                                    WHERE codigo_cliente = @codigo_cliente";

                    comando.CommandText = query;
                    comando.Parameters.AddWithValue("codigo_cliente", codCliente);

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

        public Endereco BuscarEndereco(int codEndereco)
        {
            Endereco oEndereco = null;

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM endereco_cliente WHERE codigo = @codigo;";
                    comando.Parameters.AddWithValue("codigo", codEndereco);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        oEndereco = new Endereco();
                        oEndereco.Codigo = Convert.ToInt32(reader["codigo"].ToString());

                        oEndereco.CodigoCliente = Convert.ToInt32(reader["codigo_cliente"].ToString());
                        oEndereco.Rua = reader["rua"].ToString();
                        oEndereco.Numero = Convert.ToInt32(reader["numero"].ToString());
                        if (reader["complemento"] != DBNull.Value)
                            oEndereco.Complemento = reader["complemento"].ToString();
                        oEndereco.Bairro = reader["bairro"].ToString();
                        oEndereco.Cidade = reader["cidade"].ToString();
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
            return oEndereco;
        }
    }
}
