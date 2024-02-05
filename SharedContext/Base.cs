using Curso.NotificationContext;

namespace Curso.SharedContext
{
    public class Base : Notifiable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}