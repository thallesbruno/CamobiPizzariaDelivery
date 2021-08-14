namespace Entidades.Sistema
{
    public class ComboBoxItemUsuario
    {
        public string Login { get; set; }
        public int Codigo { get; set; }
        public string Senha { get; set; }

        public ComboBoxItemUsuario(string login, int codigo, string senha)
        {
            Login = login;
            Codigo = codigo;
            Senha = senha;
        }

        public override string ToString()
        {
            return Login; 
        }
    }
}
