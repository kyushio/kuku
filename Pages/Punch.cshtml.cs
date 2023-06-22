using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kuku.Pages
{
    public class PunchModel : PageModel
    {
        private readonly ILogger<PunchModel> _logger;

        public PunchModel(ILogger<PunchModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}