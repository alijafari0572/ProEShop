using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEShop.Entities;

namespace ProEShop.DataLayer.Context;
public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
        :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
