namespace Project_K
{
    public class FSY
    {
        public double a;
        public double b;
        public FSY()
        {
            this.a = 0;
            this.b = 0;
        }
        public FSY(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double MathSokr()
        {
            return (this.a * this.a + (2 * this.b * this.a) + this.b * this.b);
        }
        public static double MathSokr(double a, double b)
        {
            return (a * a + (2 * b * a) + b * b);
        }
        public double MathSo()
        {
            return (this.a * this.a - (2 * this.b * this.a) + this.b * this.b);
        }
        public static double MathSo(double a, double b)
        {
            return (a * a - (2 * b * a) + b * b);
        }
    }
}