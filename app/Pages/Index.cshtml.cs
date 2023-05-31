using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using app.Models;
using System.IO;
using System.Text.Json;
using System.Web;
using Microsoft.Extensions.Hosting.Internal;
using System.Text;

namespace app.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly JsonFileService _snackService;
    public IEnumerable<Snack> SnackList { get; private set; }

    [BindProperty]
    public string UserEmail { get; set; } = "err";
    [BindProperty]
    public string UserPassword{get; set;}="";
    [BindProperty]
    new public  User?  User {get;set;}

    public IndexModel(ILogger<IndexModel> logger, JsonFileService snackService)
    {
        _logger = logger;
        _snackService = snackService;
        SnackList = _snackService.GetSnacks();


    }

    public void OnGet()
    {
        UserEmail="user email";

        // Snack[] list = JsonSerializer.Deserialize<Snack[]>()
        // string[] snackList = new string[]{"frikandel","kroket","bamischijf"};
    }
    public async Task<IActionResult> OnPostAsync(string?userPassword)
    {
        UserEmail = "Hello";
        await Task.Run(()=>{
             User = _snackService.GetUsers().First();
            //  var aes = System.Security.Cryptography.Aes.Create();
            //  var passWordBytes = Encoding.UTF8.GetBytes(UserPassword);
            //  aes.create
            //  var aesCrpt =aes.EncryptCbc(passWordBytes,new []{(byte)17});
            //  var aestring = Encoding.UTF8.GetString(aesCrpt);
            //  UserEmail=aestring;

            

        });
        
        return Page();

        // return Page();
        // return true;
        // return this.Page();

    }
    // public Task<IActionResult> OnPost()
    // {
    //     UserEmail = "Hello";
    //     // return true;
    //     // return this.Page();

    // }
}
