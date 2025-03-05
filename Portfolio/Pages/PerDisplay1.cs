using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class PerDisplay1Model : PageModel
{
    private readonly ILogger<PerDisplay1Model> _logger;

    public PerDisplay1Model(ILogger<PerDisplay1Model> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}