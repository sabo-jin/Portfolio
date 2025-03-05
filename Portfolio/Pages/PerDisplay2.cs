using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class PerDisplay2Model : PageModel
{
    private readonly ILogger<PerDisplay2Model> _logger;

    public PerDisplay2Model(ILogger<PerDisplay2Model> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}