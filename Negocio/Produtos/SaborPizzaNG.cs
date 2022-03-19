using BaseDados.Produtos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Produtos
{
    public class SaborPizzaNG
    {
        private readonly SaborPizzaBD _bd;

        public SaborPizzaNG()
        {
            _bd = new SaborPizzaBD();
        }

        //public bool Inserir(SaborPizza oSaborPizza)
        //{
        //    return _bd.Inserir(oSaborPizza);
        //}

        //public bool Alterar(SaborPizza oSaborPizza)
        //{
        //    return _bd.Alterar(oSaborPizza);
        //}

        //public bool Excluir(int codigo)
        //{
        //    return _bd.Excluir(codigo);
        //}

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }

        //public SaborPizza Buscar(int cod)
        //{
        //    return _bd.Buscar(cod);
        //}

        public int BuscarProximoCodigo()
        {
            return _bd.BuscarProximoCodigo();
        }
    }
}
