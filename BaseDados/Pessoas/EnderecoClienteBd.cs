using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDados.Pessoas
{
    public class EnderecoClienteBd
    {
        public List<Endereco> BuscarEnderecosCliente(int codCliente)
        {
            List<Endereco> lista = new List<Endereco>();
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
                        //oCliente.Enderecos = ...
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
    }
}
