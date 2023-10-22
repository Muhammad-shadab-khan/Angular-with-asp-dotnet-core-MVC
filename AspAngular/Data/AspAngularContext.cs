using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspAngular.Models;

namespace AspAngular.Data
{
    public class AspAngularContext : DbContext
    {
        public AspAngularContext (DbContextOptions<AspAngularContext> options)
            : base(options)
        {
        }

        public DbSet<AspAngular.Models.Employee> Employee { get; set; } = default!;
        public DbSet<AspAngular.Models.designation> designations { get; set; } = default!;
    }
}
