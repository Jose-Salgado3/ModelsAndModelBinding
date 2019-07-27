using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModelsAndModelBinding.Models
{
    public class ModelsAndModelBindingContext : DbContext
    {
        public ModelsAndModelBindingContext (DbContextOptions<ModelsAndModelBindingContext> options)
            : base(options)
        {
        }

        public DbSet<ModelsAndModelBinding.Models.Product> Product { get; set; }
    }
}
