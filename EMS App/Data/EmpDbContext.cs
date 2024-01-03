using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMS_App.Models;

namespace EMS_App.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext (DbContextOptions<EmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<EMS_App.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<EMS_App.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
