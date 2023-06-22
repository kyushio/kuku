using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kuku.Pages
{
    public class SuporteModel : PageModel
    {
        private readonly ILogger<SuporteModel> _logger;

        public SuporteModel(ILogger<SuporteModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}