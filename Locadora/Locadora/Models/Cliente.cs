using System.ComponentModel.DataAnnotations;

namespace Locadora.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "este campo é obrigatório")]
        [MaxLength(55, ErrorMessage = "Este campo deve conter entre 3 e 55 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 55 caracteres")]
        public string Nome { get; set; }

    }
}
