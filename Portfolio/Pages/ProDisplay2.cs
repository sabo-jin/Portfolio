using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class ProDisplay2Model : PageModel
{
    private readonly ILogger<ProDisplay2Model> _logger;

    public ProDisplay2Model(ILogger<ProDisplay2Model> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}