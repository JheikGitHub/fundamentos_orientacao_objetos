namespace Curso.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; } = [];
        public bool IsValid => Notifications.Count == 0;

        public void AddNotication(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}