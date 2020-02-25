using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ApiContext : DbContext  
    {  
        public DbSet<Category> Categories { get; set; }  
  
        public ApiContext(DbContextOptions options) : base(options)  
        {  
            LoadCategories();  
        }  
  
        public void LoadCategories()  
        {  
            for(int i=1; i<11; i++)
            {
                Categories.Add(
                    new Category
                    {
                        CategoryName = "Category"+i
                    }
                );
            } 
            
        }  
  
        public List<Category> GetCategories()  
        {  
            return Categories.Local.ToList<Category>();  
        }  
    }  
}