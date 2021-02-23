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
        /// <returns><see cref="IList{User}"/></returns>
        IList<User> Fetch();

        /// <summary>
        /// Find user.
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns><see cref="User"/></returns>
        User Find(int id);

        /// <summary>
        /// Create user.
        /// </summary>
        /// <param name="user">request param</param>
        void Create(User user);

        /// <summary>
        /// Update user.
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="user">request param</param>
        void Update(int id, User user);

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="id">user id</param>
        void Delete(int id);
    }

    /// <summary>
    /// UserAPI Service.
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Fetch all user.
        /// </summary>
        /// <returns><see cref="IList{User}"/></returns>
        public IList<User> Fetch()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find user.
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns><see cref="User"/></returns>
        public User Find(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create user.
        /// </summary>
        /// <param name="user">request param</param>
        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update user.
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="user">request param</param>
        public void Update(int id, User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="id">user id</param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}