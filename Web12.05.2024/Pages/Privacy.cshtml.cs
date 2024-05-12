using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace Web12._05._2024.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string Timestamp = DateTime.Now.ToString("d", new CultureInfo("ru-RU"));
            ViewData[nameof(Timestamp)] = Timestamp;
        }
    }

}
