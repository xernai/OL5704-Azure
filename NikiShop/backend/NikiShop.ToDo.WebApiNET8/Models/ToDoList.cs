using System.ComponentModel.DataAnnotations;

namespace NikiShop.ToDo.WebApiNET8.Models
{
    public class ToDoList
    {
        [Key]
        public int ToDoListId { get; set; }
        public string Name { get; set; }
    }
}
