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
                        oEndereco.CodigoCliente = Convert.ToInt32(reader["codigo_cliente"].ToString());
                        oEndereco.Rua = reader["rua"].ToString();
                        oEndereco.Numero = Convert.ToInt32(reader["numero"].ToString());
                        if (reader["complemento"] != null)
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
    }
}
