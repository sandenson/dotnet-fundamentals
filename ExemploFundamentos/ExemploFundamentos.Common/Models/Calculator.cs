namespace ExemploFundamentos.Common.Models
{
    public class Calculator
    {
        public static void Sum(int x, int y) {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        
        public static void Subtract(int x, int y) {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public static void Multiply(int x, int y) {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public static void Divide(int x, int y) {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public static void Increment(int x) {
            x ++;
            Console.WriteLine($"{x - 1} + 1 = {x}");
        }

        public static void Decrement(int x) {
            x--;
            Console.WriteLine($"{x + 1} - 1 = {x}");
        }

        public static void Power(int x, int y) {
            Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}");
        }

        public static void Remainder(int x, int y) {
            Console.WriteLine($"The remainder of {x} / {y} = {x % y}");
        }

        public static void Sin(double angleInDegrees) {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            double sin = Math.Sin(angleInRadians);
            
            Console.WriteLine($"sin {angleInDegrees}° = {Math.Round(sin, 4)}");
        }

        public static void Cos(double angleInDegrees) {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            double cos = Math.Cos(angleInRadians);

            Console.WriteLine($"cos {angleInDegrees}° = {Math.Round(cos, 4)}");
        }

        public static void Tan(double angleInDegrees) {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            double tan = Math.Tan(angleInRadians);

            Console.WriteLine($"tan {angleInDegrees}° = {Math.Round(tan, 4)}");
        }

        public static void SquareRoot(int x) {
            Console.WriteLine($"√{x} = {Math.Round(Math.Sqrt(x), 4)}");
        }
    }
}