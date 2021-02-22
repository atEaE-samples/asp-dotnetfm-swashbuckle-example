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
        /// <returns><see cref="UsersResponse"/></returns>
        public UsersResponse Get()
        {
            return new UsersResponse();
        }

        /// <summary>
        /// GET api/users/{id}
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns><see cref="UsersResponse"/></returns>
        public UsersResponse Get(int id)
        {
            return new UsersResponse();
        }

        /// <summary>
        /// POST api/users
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// PUT api/users
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// DELETE api/users/{id}
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}
