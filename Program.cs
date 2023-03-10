using System.Net.Http;
using TabbyViewer.Api;
using TabbyViewer.Configuration;

namespace TabbyViewer
{
    public class Program
    {
        static async Task RunAsync(string[] args)
        {
            var client = new HttpClient();
            Config config = ImportConfig.FromFile();
            
            client.BaseAddress = new Uri(config.Url);
            client.DefaultRequestHeaders.Add("Authorization", $"Token {config.Token}");
            
            Ops.client = client;
            Ops.config = config;
            
            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.
            builder.Services.AddRazorPages();
            
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
            
            app.UseRouting();
            
            app.UseAuthorization();
            
            app.MapRazorPages();
            
            await app.RunAsync();
        }
        static void Main(string[] args)
        {
            RunAsync(args).GetAwaiter().GetResult();
        }
    }
}