using System.ComponentModel.DataAnnotations;


namespace Locadora.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "este campo é obrigatório")]
        [MaxLength(50, ErrorMessage = "Este campo deve conter entre 1 e 50 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 50 caracteres")]
        public int Nome { get; set; }


        public int Quantidade = 1;
    }
}
