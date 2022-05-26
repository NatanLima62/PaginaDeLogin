namespace PaginaDeLogin.Entities
{
    public class Usuario
    {
        public Usuario(string name, string password, decimal balance = 0)
        {
            Name = name;
            Password = password;
            Balance = balance;
            Usuarios = new List<Usuario>();
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}