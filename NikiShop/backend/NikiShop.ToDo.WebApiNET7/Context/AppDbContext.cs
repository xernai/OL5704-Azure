using Microsoft.EntityFrameworkCore;
using NikiShop.ToDo.WebApiNET7.Models;

namespace NikiShop.ToDo.WebApiNET7.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<ToDoList> ToDoList { get; set; }
    }
}
