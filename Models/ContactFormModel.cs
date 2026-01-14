using System.ComponentModel.DataAnnotations;

namespace DentalCLinic.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Il nome è obbligatorio")]
        [StringLength(100, ErrorMessage = "Il nome non può superare i 100 caratteri")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "L'email è obbligatoria")]
        [EmailAddress(ErrorMessage = "Inserisci un'email valida")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Il telefono è obbligatorio")]
        [Phone(ErrorMessage = "Inserisci un numero di telefono valido")]
        [StringLength(20, ErrorMessage = "Il telefono non può superare i 20 caratteri")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Il messaggio è obbligatorio")]
        [StringLength(1000, ErrorMessage = "Il messaggio non può superare i 1000 caratteri")]
        [MinLength(10, ErrorMessage = "Il messaggio deve essere di almeno 10 caratteri")]
        public string Message { get; set; } = string.Empty;
    }
}
