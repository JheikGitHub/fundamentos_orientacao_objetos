namespace Curso.ContentContext
{
    public class Career: Content
    {
        public Career(string title, string url)
            : base(title, url)
        {
            Items = [];
        }

        public IList<CareerItem> Items { get; set; } = [];
        public int TotalCources => Items.Count;
    }
}