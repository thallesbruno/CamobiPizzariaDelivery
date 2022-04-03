using BaseDados.Produtos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Produtos;
using System.Collections.Generic;

namespace Negocio.Produtos
{
    public class TamanhoPizzaNG
    {
        private readonly TamanhoPizzaBD _bd;

        public TamanhoPizzaNG()
        {
            _bd = new TamanhoPizzaBD();
        }

        public bool Inserir(TamanhoPizza oTamanhoPizza)
        {
            return _bd.Inserir(oTamanhoPizza);
        }

        public bool Alterar(TamanhoPizza oTamanhoPizza)
        {
            return _bd.Alterar(oTamanhoPizza);
        }

        public bool Excluir(int codigo)
        {
            return _bd.Excluir(codigo);
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }

        public TamanhoPizza Buscar(int cod)
        {
            return _bd.Buscar(cod);
        }

        public int BuscarProximoCodigo()
        {
            return _bd.BuscarProximoCodigo();
        }
    }
}
