using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web12._05._2024.Data;
using Web12._05._2024.Models;

namespace Web12._05._2024.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Web12._05._2024.Data.Web12_05_2024Context _context;

        public IndexModel(Web12._05._2024.Data.Web12_05_2024Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
