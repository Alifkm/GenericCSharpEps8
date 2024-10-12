namespace GenericCSharp_eps8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productOne = new Product();
            var productTwo = new Product();

            bool isCompare = Comparer.AreEqual(productOne, productTwo);
            Console.WriteLine(isCompare); 

        }
    }

    class Product
    {

    }
}