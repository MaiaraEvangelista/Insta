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
        
        
    }
}