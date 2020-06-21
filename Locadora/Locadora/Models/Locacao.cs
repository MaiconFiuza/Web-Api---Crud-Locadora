using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Locadora.Models
{
    public class Locacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime DataAluguel { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime DataDevol { get; set; }


        public int IdFilme { get; set; }
        public Filme Filme { get; set; }
        public int IdCliente { get; set; }

        public Cliente Cliente { get; set; }

    }
}
