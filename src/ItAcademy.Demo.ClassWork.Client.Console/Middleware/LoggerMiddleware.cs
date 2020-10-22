using System.Threading.Tasks;
using Microsoft.Owin;

namespace ItAcademy.Demo.ClassWork.Client.Console.Middleware
{
    public class LoggerMiddleware : OwinMiddleware
    {
        public LoggerMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            System.Console.WriteLine("Middleware begin");
            await Next.Invoke(context);
            System.Console.WriteLine("Middleware end");
        }
    }
}
