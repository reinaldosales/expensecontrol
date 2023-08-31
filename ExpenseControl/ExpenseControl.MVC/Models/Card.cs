using ExpenseControl.MVC.Models.Enum;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ExpenseControl.MVC.Models
{
    public class Card
    {
        public int Id { get; set; }

        [Display(Name = "Número do cartão")]
        public string Number { get; set; }

        [Display(Name = "Tipo")]
        public CardType Type { get; set; }

        [Display(Name = "Bandeira")]
        public string Brand { get; set; }

        [Display(Name = "Limite")] 
        public decimal Limit { get; set; }

        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Display(Name = "Dia do fechamento")]
        public DateTime InvoiceClosingDate { get; set; }

        [Display(Name = "Usuário")]
        public int User { get; set; }
    }
}
