namespace NewsAggregator.Data;

public class NewsCard
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public string Source { get; set; }
    public DateTime Date { get; set; }
    public NewsCard(string title, string description, string link, string source, DateTime data)
    {
        Title = title;
        Description = description;
        Link = link;
        Source = source;
        Date = data;
    }
}
