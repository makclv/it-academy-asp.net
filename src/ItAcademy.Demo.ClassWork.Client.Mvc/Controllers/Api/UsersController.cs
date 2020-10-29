using System.Net;
using System.Net.Http;
using System.Web.Http;
using ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.Api;
using ItAcademy.Demo.ClassWork.Client.Mvc.Services.Interfaces;
using Swashbuckle.Swagger.Annotations;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers.Api
{
    /// <summary>
    /// Demo users api endpoint.
    /// </summary>
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        private readonly IUserPresentationService userPresentationService;

        public UsersController(IUserPresentationService userPresentationService)
        {
            this.userPresentationService = userPresentationService;
        }

        // GET: api/Users
        [Route("find/{name}")]
        [HttpGet]
        public IHttpActionResult Get(string name)
        {
            return Ok(userPresentationService.GetByNameWithRole(name));
        }

        // GET: api/Users/5

        /// <summary>
        /// Check all possible response types.
        /// </summary>
        /// <param name="id">Type of operation.</param>
        /// <returns>string array.</returns>
        [Route("{id}")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, "The values.", typeof(string[]))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid request data.")]
        [SwaggerResponse(HttpStatusCode.NotFound, "Value was not found.")]
        [SwaggerResponse(HttpStatusCode.Created, "Value was created.")]
        public IHttpActionResult Get(int id)
        {
            switch (id)
            {
                case 1: return Ok();
                case 2: return Ok(new string[] { "value1", "value2" });
                case 3: return BadRequest();
                case 4: return NotFound();
                case 5: return ResponseMessage(Request.CreateResponse(HttpStatusCode.Created));
                case 6:
                default:
                    return ResponseMessage(Request.CreateResponse(HttpStatusCode.Created, new string[] { "value1", "value2" }));
            }
        }

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="user">A new user.</param>
        /// <returns>The user.</returns>
        // POST: api/Users
        [Route]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, "User was created.", typeof(UserDto))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "User is not valid.")]
        public IHttpActionResult Post(UserDto user)
        {
            if (ModelState.IsValid)
            {
                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }

        [Route("V2")]
        [HttpPost]
        [ValidationActionFilter]
        public IHttpActionResult PostV2(UserDto user)
        {
            return Ok();
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
