using BaseDados.Pessoas;
using Entidades.Entidades;
using Entidades.Enumeradores;
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

        public List<EntidadeViewPesquisaCliente> ListarPesquisaCliente(Status status, string termoBusca)
        {
            return _bd.ListarPesquisaCliente(status, termoBusca);
        }
    }
}
