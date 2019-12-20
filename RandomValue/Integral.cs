using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomValue
{
    enum IntegralType
    {
        SINGLE,
        DOUBLE,
        TRIPPLE
    }

    static class Integral
    {
        private static double ax = 0.0;
        private static double ay = 0.0;
        private static double az = 0.0;

        private static double bx = 0.0;
        private static double by = 0.0;
        private static double bz = 0.0;

        private static IntegralType type = IntegralType.SINGLE;

        public static void Create(IntegralType type)
        {
            Integral.type = type;
        }

        public static void ChangeBounds(double ax = 0,
                                        double bx = 0,
                                        double ay = 0,
                                        double by = 0,
                                        double az = 0,
                                        double bz = 0)
        {
            Integral.ax = ax;
            Integral.ay = ay;
            Integral.az = az;

            Integral.bx = bx;
            Integral.by = by;
            Integral.bz = bz;
        }

        public static double NumericalMethod(double n, Func<double, double, double, double> func)
        {
            switch (Integral.type)
            {
                case IntegralType.SINGLE:
                    return SingleNM(n, func);
                case IntegralType.DOUBLE:
                    return DoubleNM(n, func);
                case IntegralType.TRIPPLE:
                    return TrippleNM(n, func);
                default:
                    return 0.0;
            }
        }
        private static double SingleNM(double n, Func<double, double, double, double> func)
        {
            double hx = (bx - ax) / n;

            double ahx = ax + hx * 0.5;

            double result = 0.0;

            for (double ix = ahx; ix < bx; ix += hx)
            {
                result += hx * func(ix, 0.0, 0.0);
            }

            return result;
        }
        private static double DoubleNM(double n, Func<double, double, double, double> func)
        {
            double hx = (bx - ax) / ((ulong)Math.Pow(n, 1.0 / 2.0));
            double hy = (by - ay) / ((ulong)Math.Pow(n, 1.0 / 2.0));

            double ahx = ax + hx * 0.5;
            double ahy = ay + hy * 0.5;

            double result = 0.0;

            for (double ix = ahx; ix < bx; ix += hx)
            {
                for (double iy = ahy; iy < by; iy += hy)
                {
                    result += hx * hy * func(ix, iy, 0.0);
                }
            }

            return result;
        }
        private static double TrippleNM(double n, Func<double, double, double, double> func)
        {
            double hx = (bx - ax) / ((ulong)Math.Pow(n, 1.0 / 3.0));
            double hy = (by - ay) / ((ulong)Math.Pow(n, 1.0 / 3.0));
            double hz = (bz - az) / ((ulong)Math.Pow(n, 1.0 / 3.0));

            double ahx = ax + hx * 0.5;
            double ahy = ay + hy * 0.5;
            double ahz = az + hz * 0.5;

            double result = 0.0;

            for (double ix = ahx; ix < bx; ix += hx)
            {
                for (double iy = ahy; iy < by; iy += hy)
                {
                    for (double iz = ahz; iz < bz; iz += hz)
                    {
                        result += hx * hy * hz * func(ix, iy, iz);
                    }
                }
            }

            return result;
        }

        public static double MonteKarloMethod(double n, Func<double, double, double, double> func)
        {
            Random random = new Random();

            double x;
            double y;
            double z;
            double volume;
            double result = 0.0;

            for (uint i = 0; i < n; ++i)
            {
                x = ax + random.NextDouble() * (bx - ax);
                y = ay + random.NextDouble() * (by - ay);
                z = az + random.NextDouble() * (bz - az);

                result += func(x, y, z);
            }

            switch (Integral.type)
            {
                case IntegralType.SINGLE:
                    volume = (bx - ax);
                    break;
                case IntegralType.DOUBLE:
                    volume = (bx - ax) * (by - ay);
                    break;
                case IntegralType.TRIPPLE:
                    volume = (bx - ax) * (by - ay) * (bz - az);
                    break;
                default:
                    volume = 0.0;
                    break;
            }

            return (volume / (double)n) * result;
        }
    }
}
