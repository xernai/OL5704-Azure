using System.ComponentModel.DataAnnotations;

namespace NikiShop.ToDo.WebApi.Models
{
    public class ToDoList
    {
        [Key]
        public int ToDoListId { get; set; }
        public string Name { get; set; }
    }
}
