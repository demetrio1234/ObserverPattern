using System;

namespace ObserverPattern.Services {
    internal class SmsService {

        public void OnItemStocked(object source, EventArgs args) {
            Console.WriteLine("SmsService: sending an SMS to notify the customer...");
        }

    }
}
