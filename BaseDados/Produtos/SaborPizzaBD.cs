using BaseDados.Modulos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Produtos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDados.Produtos
{
    public class SaborPizzaBD
    {
        private readonly FuncoesBD bdFuncoes = new FuncoesBD();

        //public bool Inserir(Adicional oAdicional)
        //{
        //    bool isRetorno = false;
        //    using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
        //    {
        //        try
        //        {
        //            conexao.Open();
        //            MySqlCommand comando = new MySqlCommand();
        //            comando = conexao.CreateCommand();

        //            comando.CommandText = @"INSERT INTO adicional (descricao, observacao, valor, situacao, dt_alteracao, codigo_usr_alteracao)" +
        //                " VALUES (@descricao, @observacao, @valor, @situacao, NOW(), @codigo_usr_alteracao)";
        //            comando.Parameters.AddWithValue("descricao", oAdicional.Descricao);
        //            comando.Parameters.AddWithValue("observacao", oAdicional.Observacao);
        //            comando.Parameters.AddWithValue("valor", oAdicional.Valor);
        //            comando.Parameters.AddWithValue("situacao", (int)oAdicional.Status);
        //            comando.Parameters.AddWithValue("codigo_usr_alteracao", oAdicional.CodigoUsrAlteracao);

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

        //public bool Alterar(Adicional oAdicional)
        //{
        //    bool isRetorno = false;
        //    using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
        //    {
        //        try
        //        {
        //            conexao.Open();
        //            MySqlCommand comando = new MySqlCommand();
        //            comando = conexao.CreateCommand();

        //            comando.CommandText = @"UPDATE adicional SET descricao = @descricao, observacao = @observacao, valor = @valor,
        //                situacao = @situacao, dt_alteracao = NOW(), codigo_usr_alteracao = @codigo_usr_alteracao,
        //                WHERE codigo = @codigo";

        //            comando.Parameters.AddWithValue("descricao", oAdicional.Descricao);
        //            comando.Parameters.AddWithValue("observacao", oAdicional.Observacao);
        //            comando.Parameters.AddWithValue("valor", oAdicional.Valor);
        //            comando.Parameters.AddWithValue("situacao", (int)oAdicional.Status);
        //            comando.Parameters.AddWithValue("codigo_usr_alteracao", oAdicional.CodigoUsrAlteracao);
        //            comando.Parameters.AddWithValue("codigo", oAdicional.Codigo);

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

        //            comando.CommandText = @"DELETE FROM adicional WHERE codigo = @codigo";
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
                                            FROM sabor_pizza";
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

        public List<SaborPizza> ListarSaboresDePizzaAtivos()
        {
            var listaSaboresDePizza = new List<SaborPizza>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM sabor_pizza WHERE situacao = 1;";
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oSaborPizza = new SaborPizza();
                        oSaborPizza.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oSaborPizza.Descricao = reader["nome"].ToString();
                        if (!(reader["observacao"] is System.DBNull))
                            oSaborPizza.Observacao = reader["observacao"].ToString();
                        oSaborPizza.ValorAdicional = Convert.ToDecimal(reader["valor_adicional"].ToString());
                        oSaborPizza.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oSaborPizza.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oSaborPizza.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());

                        listaSaboresDePizza.Add(oSaborPizza);
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
            return listaSaboresDePizza;
        }

        public SaborPizza Buscar(int cod)
        {
            SaborPizza oSaborPizza = new SaborPizza();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM sabor_pizza WHERE codigo = @codigo;";
                    comando.Parameters.AddWithValue("codigo", cod);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        oSaborPizza.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oSaborPizza.Descricao = reader["nome"].ToString();
                        if (!(reader["observacao"] is System.DBNull))
                            oSaborPizza.Observacao = reader["observacao"].ToString();
                        oSaborPizza.ValorAdicional = Convert.ToDecimal(reader["valor_adicional"].ToString());
                        oSaborPizza.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oSaborPizza.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oSaborPizza.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
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
            return oSaborPizza;
        }

        public int BuscarProximoCodigo()
        {
            return bdFuncoes.BuscaCodigo("SHOW TABLE STATUS LIKE 'sabor_pizza'");
        }
    }
}
