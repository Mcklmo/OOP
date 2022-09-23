namespace K2_inheritance
{
    class ParkingWeekend : ParkingMeter
    {
        public ParkingWeekend(double Coins) :
            base(Coins *0.9)
        {
        }
    }
}
