using BaseDados.Pessoas;
using Entidades.Entidades;
using System.Collections.Generic;

namespace Negocio.Pessoas
{
    public class EnderecoClienteNG
    {
        private readonly EnderecoClienteBD _bd;

        public EnderecoClienteNG()
        {

            _bd = new EnderecoClienteBD();
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(int codCliente)
        {
            return _bd.ListarEntidadesViewPesquisa(codCliente);
        }
    }
}
