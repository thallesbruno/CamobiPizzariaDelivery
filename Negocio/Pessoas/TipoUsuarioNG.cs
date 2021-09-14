using BaseDados.Pessoas;
using Entidades.Entidades;
using Entidades.Pessoas;
using System.Collections.Generic;

namespace Negocio.Pessoas
{
    public class TipoUsuarioNG
    {
        private readonly TipoUsuarioBD _bd;

        public TipoUsuarioNG()
        {

            _bd = new TipoUsuarioBD();
        }
        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa()
        {
            return _bd.ListarEntidadesViewPesquisa();
        }
        public TipoUsuario BuscarTipoUsuarioDoUsuario(int codigo)
        {
            return _bd.BuscarTipoUsuarioDoUsuario(codigo);
        }

        public TipoUsuario Buscar(int codigo)
        {
            return _bd.Buscar(codigo);
        }
    }
}
