using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
namespace K2_inheritance
{
    public class ParkingMeter
    {
        //3. Write a class to represent a parking meter.The parking meter should have a method to insert
        //coins and pay for x minutes. The parking rate depends on whether it is weekday or weekend.
        //Write an abstract class to capture the computation of the parking rate.Use the abstract class in
        //the parking meter to calculate rate.Write two classes, which extend the abstract class, one for
        //the rate in weekdays and one for the rate in weekends
        public ParkingMeter(double Coins)
        {
            Minutes = Coins;
        }
        public double Minutes;
    }
}
