namespace Project_K
{
    public class Matan
    {
        public double a;
        public double b;
        public Matan()
        {
            this.a = 0;
            this.b = 0;
        }
        public Matan(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double MathSokr()
        {
            return (Math.Pow(this.a, 2) + (2 * this.b * this.a) + Math.Pow(this.b, 2));
        }
        public double MathSokr(double a, double b)
        {
            return (Math.Pow(a, 2) - (2 * b * a) + Math.Pow(b, 2));
        }
    }
}