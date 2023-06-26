using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kuku.Pages
{
    public class FabioModel : PageModel
    {
        private readonly ILogger<FabioModel> _logger;

        public FabioModel(ILogger<FabioModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}