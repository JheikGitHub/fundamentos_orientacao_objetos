using Curso.SharedContext;

namespace Curso.ContentContext
{
    public class Module : Base
    {
        public Module() { }

        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; } = [];

    }
}