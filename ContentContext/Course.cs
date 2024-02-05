using Curso.ContentContext.Enums;

namespace Curso.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url, EContentLevel level)
            : base(title, url)
        {
            Level = level;
        }

        public string Tag { get; set; } //2802
        public IList<Module> Modules { get; set; } = [];
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}