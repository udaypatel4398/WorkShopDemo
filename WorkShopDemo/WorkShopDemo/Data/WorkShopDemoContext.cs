using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkShopDemo.Models;

namespace WorkShopDemo.Data
{
    public class WorkShopDemoContext : DbContext
    {
        public WorkShopDemoContext (DbContextOptions<WorkShopDemoContext> options)
            : base(options)
        {
        }

        public DbSet<WorkShopDemo.Models.Car> Car { get; set; }
    }
}
