using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeRestaurantes.Models
{
    public class Restaurante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [StringLength(50,MinimumLength = 5,ErrorMessage = "O campo deve conter de 5 a 50 caracteres.")]
        public string Nome { get; set; }

        public virtual ICollection<Prato> Pratos { get; set; }
    }
}