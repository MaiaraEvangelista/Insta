namespace Insta.Models
{
    public class Usuario : IUsuario
    {
        public int IdUsuario { get; set; }
        
        public string Nome { get; set; }
        
        public string Foto { get; set; }
        
        public string DataNascimento { get; set; }
        
        public string Email { get; set; }
        
        public string Username { get; set; }
        
        public string Senha { get; set; }

        public const string PATH = "Database/Usuario.csv";

        public string PrepararLinha(usuario u)
        {
            return $"{u.IdUsuario};{u.Nome};{u.Foto};{u.DataNascimento};{u.Email};{u.Username};{u.Senha}";
        }
        
        public void Cadastrar (usuario user)
        {
            string linha[] = {PrepararLinha(user)};
            File.AppendAllLines(PATH, linha);
        }
    }
}