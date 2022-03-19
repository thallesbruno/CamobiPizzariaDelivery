using BaseDados.Produtos;
using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Produtos;
using System.Collections.Generic;

namespace Negocio.Produtos
{
    public class AdicionalNG
    {
        private readonly AdicionalBD _bd;

        public AdicionalNG()
        {

            _bd = new AdicionalBD();
        }
        
        public bool Inserir(Adicional oAdicional)
        {
            return _bd.Inserir(oAdicional);
        }

        public bool Alterar(Adicional oAdicional)
        {
            return _bd.Alterar(oAdicional);
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }
        
        public Adicional Buscar(int cod)
        {
            return _bd.Buscar(cod);
        }
        
        public int BuscarProximoCodigo()
        {
            return _bd.BuscarProximoCodigo();
        }        
     }
}
