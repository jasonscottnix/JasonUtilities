using JasonUtilities;

namespace ConsoleForStaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string fromStatic = Helper.HelperMethod1("jsn1", 123);
            Console.WriteLine(fromStatic);

            Console.ReadLine();
        }
    }
}