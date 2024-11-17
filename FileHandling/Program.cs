using FileHandling.Methods;

namespace FileHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var fileName = "customerList";
            FilerService.ReadList(fileName);

        }

       
    }
}
