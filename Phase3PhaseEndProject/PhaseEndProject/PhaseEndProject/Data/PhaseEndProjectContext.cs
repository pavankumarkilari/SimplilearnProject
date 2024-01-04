using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhaseEndProject.Models;

namespace PhaseEndProject.Data
{
    public class PhaseEndProjectContext : DbContext
    {
        public PhaseEndProjectContext (DbContextOptions<PhaseEndProjectContext> options)
            : base(options)
        {
        }

        public DbSet<PhaseEndProject.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<PhaseEndProject.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
