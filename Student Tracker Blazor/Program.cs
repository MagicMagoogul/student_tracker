using Student_Tracker_Blazor.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace Student_Tracker_Blazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Login login = new Login();
            var builder = WebApplication.CreateBuilder(args);

            //adding this based on chat's response cause code was not working after i deleted extra web pages. Not sure-testing if it works without it
            builder.Services.AddRazorComponents()
                            .AddInteractiveServerComponents(); // Required for Blazor Server
            builder.Services.AddAntiforgery();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
               .AddInteractiveServerRenderMode();

            //login.LoginThing();

            app.Run();
        }
    }
}

