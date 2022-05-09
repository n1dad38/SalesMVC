#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CursoMVC.Models;

namespace CursoMVC.Data
{
    public class CursoMVCContext : DbContext
    {
        public CursoMVCContext (DbContextOptions<CursoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<CursoMVC.Models.Department> Department { get; set; }
    }
}
