using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class PerDisplay3Model : PageModel
{
    private readonly ILogger<PerDisplay3Model> _logger;

    public PerDisplay3Model(ILogger<PerDisplay3Model> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}