using System.ComponentModel.DataAnnotations;

namespace SistemaDeRestaurantes.Models
{
    public class Prato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O campo deve conter de 5 a 50 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo preço é obrigatório.")]
        [RegularExpression(@"^\d+([.,]\d{1,2})?$", ErrorMessage = "Este campo só deve conter números com duas casas decimais.")]
        public string Preco { get; set; }

        public int RestauranteId { get; set; }

        public virtual Restaurante Restaurante { get; set; }
    }
}
