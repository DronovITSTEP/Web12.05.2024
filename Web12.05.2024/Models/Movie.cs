using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Web12._05._2024.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength =3)]
        [Required]
        public string Title { get; set; } = string.Empty;
        [Display(Name ="Дата выпуска")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1/1/1960", "1/1/2025")]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[А-Я]+[а-яА-я\s]*$")]
        [StringLength(30)]
        [Required]
        public string Genre { get; set; } = string.Empty;

        [Range(1, 5000)]
        [DataType(DataType.Currency)]
        [Column(TypeName="decimal(18,0)")]
        public decimal Price { get; set; }
        public string Rating {  get; set; }
    }
}
