namespace GSMove
{
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        
        private static GSM iPhone4S;

        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery batteryOfGsm;
        private Display displayOfGsm;
        public GSM(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }
        public GSM(string manufacturer, string model, int price, string owner)
            : this(manufacturer, model)
        {
            this.price = price;
            this.owner = owner;
        }
        public GSM(string manufacturer, string model, int price, string owner, Battery battery, Display display)
            : this(manufacturer, model, price, owner)
        {
            this.batteryOfGsm = battery;
            this.displayOfGsm = display;
        }

    }
}
