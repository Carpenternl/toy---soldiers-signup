using IWebHostEnvironment =  Microsoft.AspNetCore.Hosting.IWebHostEnvironment;
using System.IO;
using app.Models;
using System.Text.Json;
// using IWebHostEnvironment = Microsoft.AspNetCore.Hosting.IWebHostEnvironment;

namespace app;

public class JsonFileService{
    protected IWebHostEnvironment hostingEnvironment;
    public  JsonFileService(IWebHostEnvironment hostingEnvironment){
        this.hostingEnvironment = hostingEnvironment;
    }

    private string SnackListFileName{
        get{return Path.Combine(hostingEnvironment.WebRootPath,"data","snacks.json");}
    }
    private string UserDataFileName{
        
        get{
            return Path.Combine(AppContext.BaseDirectory,"data","users.json");
        } 
    }
    public IEnumerable<Snack> GetSnacks(){
        using (var jsonFileReader = File.OpenText(SnackListFileName))
        {
            return JsonSerializer.Deserialize<Snack[]>(jsonFileReader.ReadToEnd(),new JsonSerializerOptions{
                PropertyNameCaseInsensitive=true
            });
        }
    }
    public IEnumerable<User> GetUsers(){
        using (var jsonFileReader = File.OpenText(UserDataFileName))
        {
            return JsonSerializer.Deserialize<User[]>(jsonFileReader.ReadToEnd(),new JsonSerializerOptions{
                PropertyNameCaseInsensitive=true
            });
        }
    }
}