using MySql.Data.MySqlClient;
using System;

namespace BaseDados.Modulos
{
    class FuncoesBD
    {
        public int BuscaCodigo(string sql)
        {
            int codigo = 1;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = sql;

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        codigo = Convert.ToInt32(reader["Auto_increment"].ToString());
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
            return codigo;
        }
    }
}
