using Curso.NotificationContext;
using Curso.SharedContext;

namespace Curso.SubscriptionContext
{
    public class Student : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; } = [];
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

                public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotication(new Notification("Premium", "O aluno já tem assinatura ativa"));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}