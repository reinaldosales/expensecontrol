using System.ComponentModel.DataAnnotations;
using ExpenseControl.MVC.Models.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExpenseControl.MVC.Models;

public class CreateExpenseViewModel
{
    [Display(Name = "Valor")]
    [Required(ErrorMessage = "O campo {0} é requerido")]
    public decimal Valor { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "O campo {0} é requerido")]
    public Category Category { get; set; }

    [Display(Name = "Data")]
    [Required(ErrorMessage = "O campo {0} é requerido")]
    public DateTime Date { get; set; }

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "O campo {0} é requerido")]
    public string Description { get; set; }

    [Display(Name = "Forma de Pagamento")]
    [Required(ErrorMessage = "O campo {0} é requerido")]
    public PaymentType PaymentType { get; set; }

    [Display(Name = "Número de parcelas")]
    [Required(ErrorMessage = "O campo {0} é requerido")]
    public short? NumberOfInstallments { get; set; }

    [Display(Name = "Está pago?")]
    [Required(ErrorMessage = "O campo {0} é requerido")]
    public bool ItsPaid { get; set; }

    [Display(Name = "Usuário")]
    [Required(ErrorMessage = "O campo {0} é requerido")]
    public string User { get; set; }
    
    public SelectList CategoriesListItem { get; set; }
}
