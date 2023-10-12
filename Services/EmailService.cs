using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Services {
    internal class EmailService {

        public void OnItemStocked(object source, EventArgs e) {
            Console.WriteLine("EmailService: sending an Email to notify the customer...");
        }
    }
}
