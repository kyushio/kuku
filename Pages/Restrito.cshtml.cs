using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kuku.Pages
{
    public class RestritoModel : PageModel
    {
        private readonly ILogger<RestritoModel> _logger;

        public RestritoModel(ILogger<RestritoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}