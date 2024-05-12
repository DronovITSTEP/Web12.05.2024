using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
namespace Web12._05._2024.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
