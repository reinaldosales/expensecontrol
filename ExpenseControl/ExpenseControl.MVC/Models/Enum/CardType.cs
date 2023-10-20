using System.ComponentModel.DataAnnotations;

namespace ExpenseControl.MVC.Models.Enum
{
    public enum CardType
    {
        [Display(Name = "Débito")]
        Debit = 0,
        [Display(Name = "Crédito")]
        Credit = 1
    }
}
