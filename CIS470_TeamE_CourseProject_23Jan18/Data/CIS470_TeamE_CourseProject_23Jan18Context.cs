using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CIS470_TeamE_CourseProject_23Jan18.Models
{
    public class CIS470_TeamE_CourseProject_23Jan18Context : DbContext
    {
        public CIS470_TeamE_CourseProject_23Jan18Context (DbContextOptions<CIS470_TeamE_CourseProject_23Jan18Context> options)
            : base(options)
        {
        }

        public DbSet<CIS470_TeamE_CourseProject_23Jan18.Models.Order> Order { get; set; }
    }
}
