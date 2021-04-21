using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Context
{
    public class CRUDContext : DbContext 
    {
        public CRUDContext(DbContextOptions<CRUDContext>options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
