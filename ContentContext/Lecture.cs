using Curso.ContentContext.Enums;
using Curso.SharedContext;

namespace Curso.ContentContext
{
    //Aula
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}