using System;
using System.Linq;

namespace MobilePhone.Test
{
    public class CallHistory_Test
    {
        public static void TestRunner()
        {
            GSM mobile = new GSM("Xpiria P", "Sony", null, 199.99m, null, new Battery(Battery.Type.LiIon));

            mobile.ShowInformation(); // Display mobile's information

            decimal pricePerMinute = 0.37m; // Define the price per minute

            // Add few calls
            mobile.CallHistory.Add(new Call(DateTime.Now.AddMinutes(-12314), "0123456789", new TimeSpan(1, 29, 15)));
            mobile.CallHistory.Add(new Call(DateTime.Now.AddMinutes(1210), "7635554521", new TimeSpan(2, 39, 0)));
            mobile.CallHistory.Add(new Call(DateTime.Now.AddMinutes(-652), "5524156583", new TimeSpan(3, 49, 0)));
            mobile.CallHistory.Add(new Call(DateTime.Now.AddMinutes(543), "0123456789", new TimeSpan(4, 59, 0)));
            mobile.CallHistory.Add(new Call(DateTime.Now.AddMinutes(2131), "0123456789", new TimeSpan(4, 59, 0)));

            mobile.CallHistory.Show(); // Display call history information of mobile

            Console.WriteLine("Total calls: {0}", mobile.CallHistory.Count());
            Console.WriteLine("Total price ({0}/min): {1,2}$", pricePerMinute, mobile.CallHistory.CalculatePrice(pricePerMinute));
            Console.WriteLine("Longest call: " + mobile.CallHistory.GetLongestCall());

            // Remove all the longest call from the history
            mobile.CallHistory.RemoveAllLongestCalls();

            Console.WriteLine("\n-> Deleting the longest calls...\n");

            mobile.CallHistory.Show();

            // Calculate the total price again
            Console.WriteLine("Total calls: {0}", mobile.CallHistory.Count());
            Console.WriteLine("Total price ({0}/min): {1,2}$", pricePerMinute, mobile.CallHistory.CalculatePrice(pricePerMinute));
            Console.WriteLine("Longest call: {0}\n", mobile.CallHistory.GetLongestCall());

            mobile.CallHistory.Clear(); // Clear call history

            Console.WriteLine("-> Clearing all call history...\n");

            mobile.CallHistory.Show(); // Display call history information of mobile
        }
    }
}