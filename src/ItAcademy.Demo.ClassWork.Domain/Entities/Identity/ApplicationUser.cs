using Microsoft.AspNet.Identity.EntityFramework;

namespace ItAcademy.Demo.ClassWork.Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string ItAcademyComments { get; set; }
    }
}
