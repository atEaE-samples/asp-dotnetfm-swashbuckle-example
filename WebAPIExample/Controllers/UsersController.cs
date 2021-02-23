using System.Web.Http;
using WebAPIExample.Domains;
using WebAPIExample.Models;

namespace WebAPIExample.Controllers
{
    /// <summary>
    /// UserAPI controller
    /// </summary>
    public class UsersController : ApiController
    {
        /// <summary>
        /// user domain service.
        /// </summary>
        private IUserService service;

        /// <summary>
        /// Create new UsersController instance.
        /// </summary>
        /// <param name="service">user domain service.</param>
        public UsersController(IUserService service)
        {
            this.service = service;
        }

        /// <summary>
        /// GET api/users handler.
        /// </summary>
        /// <returns><see cref="UserResponse"/></returns>
        public UserResponse Get()
        {
            var result = service.Fetch();
            return UserResponse.Create(result);
        }

        /// <summary>
        /// GET api/users/{id}
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns><see cref="UserResponse"/></returns>
        public UserResponse Get(int id)
        {
            var result = service.Find(id);
            return UserResponse.Create(result);
        }

        /// <summary>
        /// POST api/users
        /// </summary>
        /// <param name="value"><see cref="UserRequest"/></param>
        public IHttpActionResult Post([FromBody] UserRequest value)
        {
            service.Create(value.user);
            return Ok();
        }

        /// <summary>
        /// PUT api/users
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="value"><see cref="UserRequest"/></param>
        public IHttpActionResult Put(int id, [FromBody] UserRequest value)
        {
            service.Update(id, value.user);
            return Ok();
        }

        /// <summary>
        /// DELETE api/users/{id}
        /// </summary>
        /// <param name="id">user id</param>
        public IHttpActionResult Delete(int id)
        {
            service.Delete(id);
            return Ok();
        }
    }
}
