using ExpenseControl.MVC.Models.Enum;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ExpenseControl.MVC.Models
{
    public class Card
    {
        public int Id { get; set; }

        [Display(Name = "Número do cartão")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string Number { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public CardType Type { get; set; }

        [Display(Name = "Bandeira")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string Brand { get; set; }

        [Display(Name = "Limite")] 
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public decimal Limit { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public decimal Value { get; set; }

        [Display(Name = "Dia do fechamento")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public DateTime InvoiceClosingDate { get; set; }

        [Display(Name = "Usuário")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string User { get; set; }
    }
}
