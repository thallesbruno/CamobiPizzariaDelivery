using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDados.Pessoas
{
    public class EnderecoPadraoClienteBD
    {
        public int BuscarEnderecoPadraoCliente(int codCliente)
        {
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"SELECT codigo_endereco FROM endereco_padrao_cliente 
                                             WHERE codigo_cliente = @codigo_cliente LIMIT 1";
                    comando.Parameters.AddWithValue("codigo_cliente", codCliente);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                       return Convert.ToInt32(reader["codigo_endereco"].ToString();
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
            return -1;
        }
    }
}
