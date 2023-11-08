using System.ComponentModel.DataAnnotations;

namespace ExpenseControl.MVC.Models.Enum;

public enum PaymentType
{
    [Display(Name = "Cartão de Crédito")]
    CreditCard = 0,
    [Display(Name = "Cartão de Débito")]
    DebitCard = 1,
    [Display(Name = "Dinheiro")]
    Money = 2
}