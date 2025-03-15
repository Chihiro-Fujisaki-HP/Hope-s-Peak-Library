using Hope_s_Peak_Library.Components;
using Logto.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
namespace Hope_s_Peak_Library;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();
        builder.Services.AddCascadingAuthenticationState();
        builder.Services.AddLogtoAuthentication(options =>
        {
            options.Endpoint = "YOUR ENDPOINT HERE"; //Replace with your Logto endpoint
            options.AppId = "YOUR APPID HERE"; //Replace with your Logto AppId
            options.AppSecret = "YOUR APPSECRET HERE"; //Replace with your Logto AppSecret
        });
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }
     
        app.MapGet("/SignIn", async context =>
        {
            if (!(context.User?.Identity?.IsAuthenticated ?? false))
            {
                await context.ChallengeAsync(new AuthenticationProperties { RedirectUri = "/" });
            }
            else
            {
                context.Response.Redirect("/");
            }
        });

        app.MapGet("/SignOut", async context =>
        {
            if (context.User?.Identity?.IsAuthenticated ?? false)
            {
                await context.SignOutAsync(new AuthenticationProperties { RedirectUri = "/" });
            }
            else
            {
                context.Response.Redirect("/");
            }
        });
        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();
        app.UseAuthentication();
        app.Run();
    }
}
