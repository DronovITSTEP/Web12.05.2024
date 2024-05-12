using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web12._05._2024.Models;

namespace Web12._05._2024.Data
{
    public class Web12_05_2024Context : DbContext
    {
        public Web12_05_2024Context (DbContextOptions<Web12_05_2024Context> options)
            : base(options)
        {
        }

        public DbSet<Web12._05._2024.Models.Movie> Movie { get; set; } = default!;
    }
}
