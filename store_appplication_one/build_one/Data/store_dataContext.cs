using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace build_one.Models
{
    public class store_dataContext : DbContext
    {
        public store_dataContext (DbContextOptions<store_dataContext> options)
            : base(options)
        {
           
        }
        
        public DbSet<build_one.Models.ManagementModel> ManagementModel { get; set; }

    }
}
