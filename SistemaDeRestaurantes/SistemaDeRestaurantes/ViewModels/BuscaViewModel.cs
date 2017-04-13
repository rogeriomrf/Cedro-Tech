using System.ComponentModel.DataAnnotations;

namespace SistemaDeRestaurantes.ViewModels
{
    public class BuscaViewModel
    {
        [Required(ErrorMessage = "O campo é obrigatório.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O campo deve conter de 5 a 50 caracteres.")]
        public string NomeBusca { get; set; }
    }
}