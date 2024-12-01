

using Microsoft.EntityFrameworkCore;
using NikiShop.ToDo.WebApi.Models;

namespace NikiShop.ToDo.WebApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<ToDoList> ToDoList { get; set; }
    }
}
