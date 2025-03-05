using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class TestinModel : PageModel
{
    private readonly ILogger<TestinModel> _logger;

    public TestinModel(ILogger<TestinModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}