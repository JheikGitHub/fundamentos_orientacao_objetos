// See https://aka.ms/new-console-template for more information
using Curso.ContentContext;

var articles = new List<Article>
{
    new("Artigo sobre OOP", "orientacao-objetos"),
    new("Artigo sobre C#", "csharp"),
    new("Artigo sobre .NET", "dotnet"),
    new("Artigo sobre .NET Core", "dotnet-core")
};

// foreach (var article in articles)
// {
//     Console.WriteLine($"Id: {article.Id}, \n" +
//                         $"Titulo: {article.Title}, \n" +
//                         $"Url: {article.Url} \n");
// }

// Cursos
var courses = new List<Course>();
var c_csharp = new Course("Curso de C#", "curso-csharp");
var c_dotnet = new Course("Curso de C#", "curso-dotnet");
var c_oop = new Course("Curso de C#", "curso-c_oop");

//Adiciona curos
courses.Add(c_csharp);
courses.Add(c_dotnet);
courses.Add(c_oop);

//Items Carreira
var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
var careerItem = new CareerItem(1, "Comece por aqui", "", c_csharp);
var careerItem3 = new CareerItem(3, "Aprenda .NET", "", c_dotnet);

// Adiciona item curso
careerDotnet.Items.Add(careerItem2);
careerDotnet.Items.Add(careerItem3);
careerDotnet.Items.Add(careerItem);

//Carreiras - Adiciona itens
var careers = new List<Career>
{
    careerDotnet
};

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine($"    Curso: {item.Course?.Title}");
        Console.WriteLine($"    Nível: {item.Course?.Level}");

        foreach (var not in item.Notifications)
        {
            Console.WriteLine($"{not.Property} - {not.Message}");
        }
    }
}

