using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoDemo.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Escreva uma descrição.")]
        public string Description { get; set; } =string.Empty;
        [Required(ErrorMessage ="Selecione uma data. ")]
        public DateTime? DueDate { get; set; }
        [Required(ErrorMessage = "Selecione uma categoria. ")]
        public string CategoryId { get; set; } = string.Empty;
        [ValidateNever]
        public Category Category { get; set; } = null!;
        [Required(ErrorMessage = "Selecione um status. ")]
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;




    }
}
