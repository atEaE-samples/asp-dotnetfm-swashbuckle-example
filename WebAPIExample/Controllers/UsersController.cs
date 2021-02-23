using System.Web.Http;
using WebAPIExample.Models;

namespace WebAPIExample.Controllers
{
    /// <summary>
    /// UserAPI controller
    /// </summary>
    public class UsersController : ApiController
    {
        /// <summary>
        /// GET api/users handler.
        /// </summary>
        /// <returns><see cref="UserResponse"/></returns>
        public UserResponse Get()
        {
            return new UserResponse();
        }

        /// <summary>
        /// GET api/users/{id}
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns><see cref="UserResponse"/></returns>
        public UserResponse Get(int id)
        {
            return new UserResponse();
        }

        /// <summary>
        /// POST api/users
        /// </summary>
        /// <param name="value"><see cref="UserRequest"/></param>
        public void Post([FromBody] UserRequest value)
        {
        }

        /// <summary>
        /// PUT api/users
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="value"><see cref="UserRequest"/></param>
        public void Put(int id, [FromBody] UserRequest value)
        {
        }

        /// <summary>
        /// DELETE api/users/{id}
        /// </summary>
        /// <param name="id">user id</param>
        public void Delete(int id)
        {
        }
    }
}
