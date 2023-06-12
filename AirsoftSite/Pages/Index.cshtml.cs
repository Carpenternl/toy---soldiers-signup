using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text.Json;
using System.Web;
using Microsoft.Extensions.Hosting.Internal;
using System.Text;

namespace AirsoftSite.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

        // Snack[] list = JsonSerializer.Deserialize<Snack[]>()
        // string[] snackList = new string[]{"frikandel","kroket","bamischijf"};
    }
    // public async Task<IActionResult> OnPostAsync(string?userPassword)
    // {

    //     // return Page();
    //     // return true;
    //     // return this.Page();

    // }
    // public Task<IActionResult> OnPost()
    // {
    //     UserEmail = "Hello";
    //     // return true;
    //     // return this.Page();

    // }
}
