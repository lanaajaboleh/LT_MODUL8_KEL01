namespace Perc2Mod8
{
    public class TempConv
    {
        public double cToF(double c)
        {
            return (int)((c * 9) / 5.0 + 32);
        }
        public double fToc(double f)
        {
            return (int)((f - 32) * 5 / 9.0);
        }

        public double cToR(double c)
        {
            return (int)((c * 4) / 5.0);
        }

        public double cToK(double c)
        {
            return (int)((c + 273.15));
        }

        public double fToR(double f)
        {
            return (int)((f - 32) * 5 / 4.0);
        }

        public double fToK(double f)
        {
            return (int)(((f - 32)/1.8) + 273.15);
        }

        public double rToC(double r)
        {
            return (int)((5/4) * r);
        }

        public double rToF(double r)
        {
            return (int)(((9 / 4) * r) + 32);
        }

        public double rToK(double r)
        {
            return (int)(((5 / 4) * r) + 273.15);
        }

        public double kToC(double k)
        {
            return (int) (k - 273.15);
        }

        public double kToF(double k)
        {
            return (int)((9/5) * (k - 273.15) + 32);
        }

        public double kToR(double k)
        {
            return (int)((4 / 5) * (k - 273.15));
        }
    }
}