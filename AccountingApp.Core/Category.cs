using System.ComponentModel.DataAnnotations;

namespace AccountingApp.Core
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
    }
}