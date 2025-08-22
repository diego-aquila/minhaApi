using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MinhaAPI.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O logradouro é obrigatório")]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "O logradouro é obrigatório")]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "A cidade é obrigatória")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O estado é obrigatório")]
        public string Estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CEP é obrigatório")]
        [StringLength(9, MinimumLength =8, ErrorMessage ="O CEP deve ter entre 8 e 9 caracteres")]
        public string CEP { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Número é obrigatório")]
        public string Numero { get; set; } = string.Empty;

        public string? Complemento { get; set; }

        public int ClienteId { get; set; }

        [JsonIgnore]
        public Cliente? Cliente { get; set; }

    }
}
