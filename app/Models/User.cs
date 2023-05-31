namespace app.Models;
public class User
{
    private int _id=0;
    public string Name { get; set; }
    public string Group{get; private set;}
    public string Email { get; set; }

    private string? _password;
}
