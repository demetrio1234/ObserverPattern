using ObserverPattern.Services;

namespace ObserverPattern {
    internal class Program {
        static void Main(string[] args) {

            Item item = new Item { Id = 1 , Name = "Bottle" };
            
            ItemNotifier store = new ItemNotifier();

            EmailService emailService = new EmailService();

            MessageService messageService = new MessageService();

            SmsService smsService = new SmsService();

            store.ItemStocked += emailService.OnItemStocked;
            store.ItemStocked += messageService.OnItemStocked;
            store.ItemStocked += smsService.OnItemStocked;


            store.Stock(item);

        }
    }
}
