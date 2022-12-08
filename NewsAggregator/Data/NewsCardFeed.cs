using System.Xml;
using System.Text;
using System.ServiceModel.Syndication;

namespace NewsAggregator.Data
{
    public class NewsCardFeed
    {
        public List<NewsCard> Items { get; set; }

        public NewsCardFeed(string url, string source)
        {
            Items = new List<NewsCard>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                string title = item.Title.Text;
                string description = item.Summary.Text;
                string link = item.Links[0].Uri.ToString();
                DateTime date = item.PublishDate.DateTime;
                Items.Add(new NewsCard(title, description, link, source, date));
            }
        }
    }
}
