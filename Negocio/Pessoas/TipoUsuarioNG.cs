using BaseDados.Pessoas;
using Entidades.Pessoas;

namespace Negocio.Pessoas
{
    public class TipoUsuarioNG
    {
        private readonly TipoUsuarioBD _bd;

        public TipoUsuarioNG()
        {

            _bd = new TipoUsuarioBD();
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
