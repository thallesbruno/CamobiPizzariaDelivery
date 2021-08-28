using BaseDados.Pessoas;
using Entidades.Pessoas;
using System.Collections.Generic;

namespace Negocio.Pessoas
{
    public class UsuarioNG
    {
        private readonly UsuarioBD _bd;

        public UsuarioNG()
        {

            _bd = new UsuarioBD();
        }

        public List<Usuario> ListarUsuariosAtivos()
        {
            return _bd.ListarEntidadesViewPesquisa();
        }
    }
}
