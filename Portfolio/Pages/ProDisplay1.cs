using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class ProDisplay1Model : PageModel
{
    private readonly ILogger<ProDisplay1Model> _logger;

    public ProDisplay1Model(ILogger<ProDisplay1Model> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}