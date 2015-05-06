using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMove
{
    class DefineGSM
    {
        const string model = "Nokia";
        const string manifacturer = "Jango";

        int price;
        string owner;

        static void Main()
        {
            Battery newBattery = new Battery("NG-1000", 24, 18, BatteryType.LiPoly);
            Display newDisplay = new Display(5, 16);

            GSM myGSM = new GSM("Nokia", "3310", 100, "Jango", newBattery, newDisplay);

            //Console.WriteLine(newBattery);
            //Console.WriteLine(newDisplay);
            //Console.WriteLine(myGSM);
        }


    }
}
