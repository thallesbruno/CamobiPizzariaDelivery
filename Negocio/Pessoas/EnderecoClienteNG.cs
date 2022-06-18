using BaseDados.Pessoas;
using Entidades.Entidades;
using Entidades.Pessoas;
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

        public Endereco BuscarEndereco(int codEndereco)
        {
            return _bd.BuscarEndereco(codEndereco);
        }
    }
}
