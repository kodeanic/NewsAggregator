using NewsAggregator.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Data.Sqlite;


using (var db = new ApplicationContext())
{
    if (db.Sources.Count() == 0)
    {
        db.Sources.Add(new Source { Title = "Кинопоиск", Link = "https://www.kinopoisk.ru/news.rss" });
        db.Sources.Add(new Source { Title = "FILMZ.RU", Link = "http://www.filmz.ru/rss/files/news7.xml" });
        db.Sources.Add(new Source { Title = "Кинокадр", Link = "http://www.kinokadr.ru/export/rss.xml" });

        db.SaveChanges();
    }
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
