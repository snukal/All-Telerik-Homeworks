using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMove
{
    public class Battery
    {
        readonly string model;
        uint hoursIdle;
        uint hoursTalk;
        private BatteryType typeBattery;


        public Battery(string model)
        {
            this.model = model;

        }
        public Battery(string model, uint hoursIdle, uint hoursTalk) : this(model)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public Battery(string model, uint hoursIdle, uint hoursTalk, BatteryType type)
            : this(model, hoursIdle, hoursTalk)
        {
            this.typeBattery = type;
        }
        public override string ToString()
        {
            return this.model + " " + this.hoursIdle+ " " + this.hoursTalk ;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public uint HoursOfIdle
        {
            get
            {
                return this.hoursIdle;
            }
        }

        public uint HoursOfTalk
        {
            get
            {
                return this.hoursTalk;
            }
        }

        public BatteryType Type
        {
            get
            {
                return this.typeBattery;
            }
        }
    }
}
