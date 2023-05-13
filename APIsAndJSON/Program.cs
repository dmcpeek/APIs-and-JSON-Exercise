using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                RonVSKanyeAPI.RonS();

                RonVSKanyeAPI.Kanye();

                Console.WriteLine("----------");

            }
            Console.WriteLine("Press the any key to exit");
            Console.ReadKey();
        }
    }
}