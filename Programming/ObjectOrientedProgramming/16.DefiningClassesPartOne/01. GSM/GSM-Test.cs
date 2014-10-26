using System;
using System.Collections.Generic;

namespace MobilePhone.Test
{
    class GSM_Test
    {
        public static void TestRunner()
        {
            List<GSM> mobilePhones = new List<GSM>();
            {
                mobilePhones.Add(new GSM("Asha 501", "Nokia", "GLOBUL", 599.99m, new Display(3, 1250000)));
            }

            {
                GSM mobile = new GSM("Xperia ray", "Sony Ericsson");
                mobile.Owner = "Vivacom";
                mobile.Price = 250;

                mobile.Battery = new Battery(Battery.Type.NiMH);
                mobile.Battery.HoursTalk = 200;

                mobilePhones.Add(mobile);
            }

            // Display information about phones in array
            foreach (var phone in mobilePhones)
                Console.Write(phone);

            // Mobile N.3
            // Display information about IPhone 4S
            Console.Write(GSM.Iphone4S);
        }
    }
}