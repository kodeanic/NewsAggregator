using NewsAggregator.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Data.Sqlite;

/*
using (var connection = new SqliteConnection("Data Source=sourcesdata.db"))
{
    connection.Open();
    
    SqliteCommand command = new SqliteCommand();
    command.Connection = connection;
    command.CommandText = "CREATE TABLE Sources (_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Title TEXT NOT NULL, IsPicked INTEGER NOT NULL, Link TEXT NOT NULL)";
    command.ExecuteNonQuery();
    command.CommandText = "INSERT INTO Sources (Title, IsPicked, Link) VALUES ('Кинопоиск', 1, 'https://www.kinopoisk.ru/news.rss'), ('FILMZ.RU', 1, 'http://www.filmz.ru/rss/files/news7.xml'), ('Кинокадр', 1, 'http://www.kinokadr.ru/export/rss.xml')";
    command.ExecuteNonQuery();
    
    connection.Close();
}
*/
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
