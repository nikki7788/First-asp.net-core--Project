using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ApplicationDbContex:DbContext
    {

        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> option) : base(option)
        {

        }

        public DbSet<Members>Members { get; set; }


    }
}
