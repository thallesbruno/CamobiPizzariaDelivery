using BaseDados.Produtos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Produtos;
using System.Collections.Generic;

namespace Negocio.Produtos
{
    public class SaborBordaNG
    {
        private readonly SaborBordaBD _bd;

        public SaborBordaNG()
        {
            _bd = new SaborBordaBD();
        }

        public bool Inserir(SaborBorda oSaborBorda)
        {
            return _bd.Inserir(oSaborBorda);
        }

        public bool Alterar(SaborBorda oSaborBorda)
        {
            return _bd.Alterar(oSaborBorda);
        }

        public bool Excluir(int codigo)
        {
            return _bd.Excluir(codigo);
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }

        public SaborBorda Buscar(int cod)
        {
            return _bd.Buscar(cod);
        }

        public int BuscarProximoCodigo()
        {
            return _bd.BuscarProximoCodigo();
        }
    }
}
