﻿using BaseDados.Pessoas;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using System.Collections.Generic;

namespace Negocio.Pessoas
{
    public class ClienteNG
    {
        private readonly ClienteBD _bd;

        public ClienteNG()
        {

            _bd = new ClienteBD();
        }

        public bool Inserir(Cliente oCliente)
        { 
            return _bd.Inserir(oCliente);
        }

        public bool Alterar(Cliente oCliente)
        {
            return _bd.Alterar(oCliente);
        }
        public bool Excluir(int iCodCliente)
        {
            return _bd.Excluir(iCodCliente);
        }
        public List<EntidadeViewPesquisaCliente> ListarPesquisaCliente(Status status, string termoBusca)
        {
            return _bd.ListarPesquisaCliente(status, termoBusca);
        }
        public Cliente Buscar(int cod)
        {
            return _bd.Buscar(cod);
        }
        public Cliente BuscarPorContato(long numeroContato)
        {
            return _bd.BuscarPorContato(numeroContato);
        }
        public int BuscarProximoCodigo()
        {
            return _bd.BuscarProximoCodigo();
        }
    }
}
