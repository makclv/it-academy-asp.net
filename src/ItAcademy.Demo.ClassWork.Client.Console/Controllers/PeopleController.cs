using System.Web.Http;

namespace ItAcademy.Demo.ClassWork.Client.Console.Controllers
{
    public class PeopleController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new { Name = "Vasya", Age = 25 });
        }
    }
}
