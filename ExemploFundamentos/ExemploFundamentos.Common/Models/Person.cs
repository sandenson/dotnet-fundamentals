namespace ExemploFundamentos.Common.Models
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        
        public void Introduce() {
            Console.WriteLine($"Hello, my name is {Name}, and I'm {Age} years old.");
        }
    }
}