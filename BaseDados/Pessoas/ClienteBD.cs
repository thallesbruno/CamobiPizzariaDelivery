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

        public bool Inserir(Cliente oCliente)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                MySqlTransaction transacao = null;
                try
                {
                    conexao.Open();

                    transacao = conexao.BeginTransaction();

                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.Connection = conexao;
                    comando.Transaction = transacao;
                    
                    int valorRetorno = 0;

                    //################## INSERE O CLIENTE ##################
                    comando.CommandText = @"INSERT INTO cliente (
                                                nome,
                                                telefone,
                                                celular,
                                                situacao,
                                                dt_alteracao,
                                                codigo_usr_alteracao)
                                            VALUES (
                                                @nome,
                                                @telefone,
                                                @celular,
                                                @situacao,
                                                NOW(),
                                                @codigo_usr_alteracao)";

                    comando.Parameters.AddWithValue("nome", oCliente.Nome);
                    comando.Parameters.AddWithValue("telefone", oCliente.Telefone);
                    comando.Parameters.AddWithValue("celular", oCliente.Celular);
                    comando.Parameters.AddWithValue("situacao", oCliente.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oCliente.CodigoUsrAlteracao);

                    valorRetorno = comando.ExecuteNonQuery();
                    if (valorRetorno < 1)
                        return isRetorno;

                    comando.CommandText = string.Empty;
                    comando.Parameters.Clear();

                    //################## BUSCA O CODIGO DO CLIENTE INSERIDO ##################
                    comando.CommandText = "SHOW TABLE STATUS LIKE 'cliente'";

                    int iCodClienteInserido = 0;

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                            iCodClienteInserido = Convert.ToInt32(reader["Auto_increment"].ToString()) - 1;
                    }

                    comando.CommandText = string.Empty;
                    comando.Parameters.Clear();

                    //################## INSERIR ENDERECOS ##################
                    foreach (Endereco oEnd in oCliente.Enderecos)
                    {
                        oEnd.CodigoCliente = iCodClienteInserido;

                        comando.CommandText = @"INSERT INTO endereco_cliente (
                                                    codigo_cliente,
                                                    rua,
                                                    numero,
                                                    complemento,
                                                    bairro,
                                                    cidade)
                                                VALUES
                                                    (@codigo_cliente,
                                                    @rua,
                                                    @numero,
                                                    @complemento,
                                                    @bairro,
                                                    @cidade);";

                        comando.Parameters.AddWithValue("codigo_cliente", oEnd.CodigoCliente);
                        comando.Parameters.AddWithValue("rua", oEnd.Rua);
                        comando.Parameters.AddWithValue("numero", oEnd.Numero);
                        comando.Parameters.AddWithValue("complemento", oEnd.Complemento);
                        comando.Parameters.AddWithValue("bairro", oEnd.Bairro);
                        comando.Parameters.AddWithValue("cidade", oEnd.Cidade);

                        valorRetorno = comando.ExecuteNonQuery();
                        if (valorRetorno < 1)
                            return isRetorno;

                        comando.CommandText = string.Empty;
                        comando.Parameters.Clear();

                        if (oEnd.IsEnderecoPadrao)
                        {
                            //Buscar o codigo do endereco inserido
                            comando.CommandText = "SHOW TABLE STATUS LIKE 'endereco_cliente'";

                            int iCodEnderecoCliente = 0;

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                while (reader.Read())
                                    iCodClienteInserido = Convert.ToInt32(reader["Auto_increment"].ToString()) - 1;
                            }

                            comando.CommandText = string.Empty;
                            comando.Parameters.Clear();

                            //Inserir o endereco padrao
                            comando.CommandText = @"INSERT INTO endereco_padrao_cliente (
                                                    codigo_cliente,
                                                    codigo_endereco)
                                                VALUES
                                                    (@codigo_cliente,
                                                    @codigo_endereco);";

                            comando.Parameters.AddWithValue("codigo_cliente", iCodClienteInserido);
                            comando.Parameters.AddWithValue("codigo_endereco", iCodEnderecoCliente);

                            valorRetorno = comando.ExecuteNonQuery();
                            if (valorRetorno < 1)
                                return isRetorno;

                            comando.CommandText = string.Empty;
                            comando.Parameters.Clear();
                        }
                    }

                    isRetorno = true;
                }
                catch (MySqlException mysqle)
                {
                    throw new Exception(mysqle.ToString());
                }
                finally
                {
                    if (!isRetorno)
                        transacao.Rollback();
                    else
                        transacao.Commit();

                    conexao.Close();
                }
            }
            return isRetorno;
        }

        public bool Alterar(Cliente oCliente)
        {
            bool isRetorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                MySqlTransaction transacao = null;
                try
                {
                    conexao.Open();

                    transacao = conexao.BeginTransaction();

                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.Connection = conexao;
                    comando.Transaction = transacao;

                    int valorRetorno = 0;

                    //################## ALTERA O CLIENTE ##################

                    comando.CommandText = @"UPDATE cliente SET 
                                                nome = @nome,
                                                telefone = @telefone,
                                                celular = @celular,
                                                situacao = @situacao,
                                                dt_alteracao = NOW(),
                                                codigo_usr_alteracao = @codigo_usr_alteracao
                                            WHERE (codigo = @codigo)";

                    comando.Parameters.AddWithValue("codigo", oCliente.Codigo);
                    comando.Parameters.AddWithValue("nome", oCliente.Nome);
                    comando.Parameters.AddWithValue("telefone", oCliente.Telefone);
                    comando.Parameters.AddWithValue("celular", oCliente.Celular);
                    comando.Parameters.AddWithValue("situacao", oCliente.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oCliente.CodigoUsrAlteracao);

                    valorRetorno = comando.ExecuteNonQuery();
                    if (valorRetorno < 1)
                        return isRetorno;

                    comando.CommandText = string.Empty;
                    comando.Parameters.Clear();

                    //################## REMOVER ENDERECOS ANTIGOS ##################

                    comando.CommandText = "DELETE FROM endereco_cliente WHERE codigo_cliente = @codigo_cliente";

                    comando.Parameters.AddWithValue("codigo_cliente", oCliente.Codigo);

                    valorRetorno = comando.ExecuteNonQuery();
                    if (valorRetorno < 1)
                        return isRetorno;

                    comando.CommandText = string.Empty;
                    comando.Parameters.Clear();

                    //################## INSERIR ENDERECOS NOVOS ##################

                    foreach (Endereco oEnd in oCliente.Enderecos)
                    {
                        oEnd.CodigoCliente = oCliente.Codigo;

                        comando.CommandText = @"INSERT INTO endereco_cliente (
                                                    codigo_cliente,
                                                    rua,
                                                    numero,
                                                    complemento,
                                                    bairro,
                                                    cidade)
                                                VALUES
                                                    (@codigo_cliente,
                                                    @rua,
                                                    @numero,
                                                    @complemento,
                                                    @bairro,
                                                    @cidade);";

                        comando.Parameters.AddWithValue("codigo_cliente", oEnd.CodigoCliente);
                        comando.Parameters.AddWithValue("rua", oEnd.Rua);
                        comando.Parameters.AddWithValue("numero", oEnd.Numero);
                        comando.Parameters.AddWithValue("complemento", oEnd.Complemento);
                        comando.Parameters.AddWithValue("bairro", oEnd.Bairro);
                        comando.Parameters.AddWithValue("cidade", oEnd.Cidade);

                        valorRetorno = comando.ExecuteNonQuery();
                        if (valorRetorno < 1)
                            return isRetorno;

                        comando.CommandText = string.Empty;
                        comando.Parameters.Clear();

                        if (oEnd.IsEnderecoPadrao)
                        {
                            //Buscar o codigo do endereco inserido
                            comando.CommandText = "SHOW TABLE STATUS LIKE 'endereco_cliente'";

                            int iCodEnderecoCliente = 0;

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                while (reader.Read())
                                    iCodEnderecoCliente = Convert.ToInt32(reader["Auto_increment"].ToString()) - 1;
                            }

                            comando.CommandText = string.Empty;
                            comando.Parameters.Clear();

                            //Inserir o endereco padrao
                            comando.CommandText = @"UPDATE endereco_padrao_cliente SET 
                                                        codigo_endereco = @codigo_endereco
                                                    WHERE codigo_cliente = @codigo_cliente";

                            comando.Parameters.AddWithValue("codigo_cliente", oCliente.Codigo);
                            comando.Parameters.AddWithValue("codigo_endereco", iCodEnderecoCliente);

                            valorRetorno = comando.ExecuteNonQuery();
                            if (valorRetorno < 1)
                                return isRetorno;

                            comando.CommandText = string.Empty;
                            comando.Parameters.Clear();
                        }
                    }

                    isRetorno = true;
                }
                catch (MySqlException mysqle)
                {
                    throw new Exception(mysqle.ToString());
                }
                finally
                {
                    if (!isRetorno)
                        transacao.Rollback();
                    else
                        transacao.Commit();

                    conexao.Close();
                }
            }
            return isRetorno;
        }

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
                        if (!(reader["telefone"] is System.DBNull))
                            oEntidade.Telefone = Convert.ToInt64(reader["telefone"]).ToString("(##) ####-####");
                        if (!(reader["celular"] is System.DBNull))
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
                        if (reader["telefone"] != null && reader["telefone"].ToString() != string.Empty)
                            oCliente.Telefone = Convert.ToInt64(reader["telefone"].ToString());
                        if (reader["celular"] != null && reader["celular"].ToString() != string.Empty)
                            oCliente.Celular = Convert.ToInt64(reader["celular"].ToString());
                        oCliente.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oCliente.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());                        
                        oCliente.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        oCliente.Enderecos = new EnderecoClienteBD().BuscarEnderecosCliente(oCliente.Codigo);
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
            return bdFuncoes.BuscaCodigo("SHOW TABLE STATUS LIKE 'cliente'");
        }
    }
}
