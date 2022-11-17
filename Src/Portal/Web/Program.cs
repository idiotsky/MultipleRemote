using Impl;
using Interface;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IUserService, UserService>();

WebApplication app = builder.Build();
app.UseHttpsRedirection();

app.MapRazorPages();

app.Run();
