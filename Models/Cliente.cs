using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;


        [StringLength(100, ErrorMessage = "O email deve ter no máximo 100 caracteres")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; } = string.Empty;

        [StringLength(14, MinimumLength = 11, ErrorMessage = "O email deve ter no máximo 100 caracteres")]
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string Cpf { get; set; } = string.Empty;

        [StringLength(14, MinimumLength = 11, ErrorMessage = "O email deve ter no máximo 100 caracteres")]
        [Required(ErrorMessage = "O telefone é obrigatório")]
         public string Telefone { get; set; } = string.Empty;

        public List<Endereco> Enderecos { get; set; } = new List<Endereco>();




    }
}
