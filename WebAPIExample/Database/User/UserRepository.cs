using System;
using System.Collections.Generic;

namespace WebAPIExample.Database.User
{
    /// <summary>
    /// User repository
    /// </summary>
    public class UserRepository
    {
        /// <summary>
        /// Fetch all users.
        /// </summary>
        /// <returns>all users</returns>
        public IEnumerable<UserDao> Fetch()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find user by id.
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>target user</returns>
        public UserDao Find(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="user">user info</param>
        public void Create(UserDao user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update user.
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="user">user info</param>
        public void Update(int id, UserDao user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="id">user id</param>
        public void Delate(int id)
        {
            throw new NotImplementedException();
        }
    }
}