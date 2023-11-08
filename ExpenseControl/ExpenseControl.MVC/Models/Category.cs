using ExpenseControl.MVC.Models.Enum;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ExpenseControl.MVC.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string Name { get; set; }

        [Display(Name = "Usuário")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string User { get; set; }
    }
}
