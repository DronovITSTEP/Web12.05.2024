using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty(SupportsGet = true)]
        public string? SearchString {  get; set; }
        public SelectList? Genres {  get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;


            var movies = from m in _context.Movie select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(s => s.Genre == MovieGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            Movie = await movies.ToListAsync();
        }
    }
}
