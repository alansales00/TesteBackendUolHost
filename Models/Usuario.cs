namespace TesteBackendUol.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Grupo { get; set; } = string.Empty;
        public string Codinome { get; set; } = string.Empty;

    }
}