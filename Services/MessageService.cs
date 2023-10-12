using System;

namespace ObserverPattern {
    internal class MessageService {
        public void OnItemStocked(object source, EventArgs e) {
            Console.WriteLine("EmailService: sending a Message to notify the customer...");
        }

    }
}