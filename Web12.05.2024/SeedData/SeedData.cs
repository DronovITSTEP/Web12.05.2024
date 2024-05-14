using Microsoft.EntityFrameworkCore;
using Web12._05._2024.Data;

namespace Web12._05._2024.SeedData
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Web12_05_2024Context(
                serviceProvider.GetRequiredService<DbContextOptions
                <Web12_05_2024Context>>()))
            {
                if (context == null || context.Movie == null)
                    throw new ArgumentNullException("Null Web12_05_2024Context");

                if (context.Movie.Any()) return;

                context.Movie.AddRange(
                    new Models.Movie
                    {
                        Title = "Елки 10",
                        ReleaseDate = DateTime.Parse("12-12-2023"),
                        Genre = "Комедия",
                        Price = 2350,
                        Rating="21+"
                    },
                    new Models.Movie
                    {
                        Title = "Особенности национальной охоты",
                        ReleaseDate = DateTime.Parse("25-02-2004"),
                        Genre = "Комедия",
                        Price = 1999,
                        Rating = "35+"
                    }, 
                    new Models.Movie
                    {
                        Title = "Майор Гром",
                        ReleaseDate = DateTime.Parse("13-04-2022"),
                        Genre = "Триллер",
                        Price = 2599,
                        Rating = "5+"
                    },
                    new Models.Movie
                    {
                        Title = "Кавказская пленница",
                        ReleaseDate = DateTime.Parse("20-06-1974"),
                        Genre = "Комедия",
                        Price = 1699,
                        Rating = "0+"
                    }
                    );
                context.SaveChanges();
            }
            
        }
    }
}
