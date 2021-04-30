using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PP_LAB_4.Models;

namespace PP_LAB_4.Data
{
    public class PP_LAB_4Context : DbContext
    {
        public PP_LAB_4Context (DbContextOptions<PP_LAB_4Context> options)
            : base(options)
        {
        }

        public DbSet<PP_LAB_4.Models.currency> currency { get; set; }
    }
}
