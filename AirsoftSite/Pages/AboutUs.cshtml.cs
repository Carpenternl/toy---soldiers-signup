using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AirsoftSite.Pages;
public class AboutUsModel : PageModel
{
    public string Title { get; set; } = "Over Ons";
    public string Description { get; set; } = "lorem ipsum";
    public AboutUsModel()
    {

    }

}

