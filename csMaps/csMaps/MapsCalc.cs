namespace csMaps
{
    public class MapsCalc
    {
        internal const double PIx = 3.141592653589793;
        internal const double RADIUS = 6378.16;

        internal static double Radians(double x)
        {
            return x * PIx / 180;
        }
    }
}