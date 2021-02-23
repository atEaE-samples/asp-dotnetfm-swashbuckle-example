using System;
using System.Collections.Generic;
using WebAPIExample.Models;

namespace WebAPIExample.Domains
{
    /// <summary>
    /// Inteface of user service.
    /// </summary>
    public interface IUserService 
    {
        /// <summary>
        /// Fetch all user.
        /// </summary>
        /// <returns><see cref="IEnumerable{User}"/></returns>
        IEnumerable<User> Fetch();

        /// <summary>
        /// Find user.
        /// </summary>
        /// <returns><see cref="User"/></returns>
        User Find();

        /// <summary>
        /// Create user.
        /// </summary>
        void Create();

        /// <summary>
        /// Update user.
        /// </summary>
        void Update();

        /// <summary>
        /// Delete user.
        /// </summary>
        void Delete();
    }

    /// <summary>
    /// UserAPI Service.
    /// </summary>
    public class UserService : IUserService
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Fetch()
        {
            throw new NotImplementedException();
        }

        public User Find()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}