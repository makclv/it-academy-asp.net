using Microsoft.Owin.Hosting;

namespace ItAcademy.Demo.ClassWork.Client.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:8080"))
            {
                System.Console.WriteLine("Prease any key to quit.");
                System.Console.ReadKey();
            }
        }
    }
}
