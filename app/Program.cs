using System.Text.Json;
using app;
using app.Models;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<JsonFileService>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// app.MapGet("/snacks",(context)=>{
//     if (context is null)
//     {
//         throw new ArgumentNullException(nameof(context));
//     }

//     var products = app.Services.GetService<JsonFileService>().GetSnacks();
//     var json = JsonSerializer.Serialize<IEnumerable<Snack>>(products);
//     context.Response.ContentType = "application/json";
//     return context.Response.WriteAsync(json);
// });
app.MapControllers();
app.MapRazorPages();

app.Run();
