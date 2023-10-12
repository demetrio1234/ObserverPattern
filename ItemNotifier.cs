using System;

namespace ObserverPattern {


    public class ItemNotifier {

        public delegate void ItemStockedEventHandler(object source, EventArgs args);

        public event ItemStockedEventHandler ItemStocked;

        public void Stock(Item item) {

            OnItemStocked();
        }

        protected virtual void OnItemStocked() {

            if (ItemStocked != null)
                ItemStocked(this, EventArgs.Empty);

        }

    }
}