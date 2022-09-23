namespace K2_inheritance
{
    class ParkingWeekday : ParkingMeter
    {
        public ParkingWeekday(double Coins) :
            base(Coins * 1.1)
        {
        }
    }
}
