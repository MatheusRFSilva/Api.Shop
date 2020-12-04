using System.ComponentModel.DataAnnotations;


namespace Shop.Models
{

    public class Category
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 Caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 Caracteres")]
        public string Title { get; set; }

    }
}