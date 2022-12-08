namespace NewsAggregator.Data
{
    public class Source
    {
        public string Title { get; set; }
        public bool IsPicked { get; set; }
        public string Link { get; set; }
        public Source(string title, bool isPicked, string link)
        {
            Title = title;
            IsPicked = isPicked;
            Link = link;
        }
    }
}
