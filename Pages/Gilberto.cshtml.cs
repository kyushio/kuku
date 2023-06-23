using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kuku.Pages
{
    public class GilbertoModel : PageModel
    {
        private readonly ILogger<GilbertoModel> _logger;

        public GilbertoModel(ILogger<GilbertoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}