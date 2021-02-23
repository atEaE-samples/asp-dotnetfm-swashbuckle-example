using System;
using System.Collections.Generic;
using System.Linq;
using WebAPIExample.Database.User;
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
        /// user repository.
        /// </summary>
        private UserRepository userRepo = new UserRepository();

        /// <summary>
        /// Fetch all user.
        /// </summary>
        /// <returns><see cref="IList{User}"/></returns>
        public IList<User> Fetch()
        {
            return userRepo.Fetch().Select(x => daoToParam(x)).ToList();
        }

        /// <summary>
        /// Find user.
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns><see cref="User"/></returns>
        public User Find(int id)
        {
            var result = userRepo.Find(id);
            if (result == null)
            {
                return null;
            }
            else
            {
                return daoToParam(result);
            }
        }

        /// <summary>
        /// Create user.
        /// </summary>
        /// <param name="user">request param</param>
        public void Create(User user)
        {
            var dao = paramToDao(user);
            userRepo.Create(dao);
        }

        /// <summary>
        /// Update user.
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="user">request param</param>
        public void Update(int id, User user)
        {
            var dao = paramToDao(user);
            userRepo.Update(id, dao);
        }

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="id">user id</param>
        public void Delete(int id)
        {
            userRepo.Delate(id);
        }

        /// <summary>
        /// Convert param to dao.
        /// </summary>
        /// <param name="param">user param</param>
        /// <returns>dao</returns>
        private UserDao paramToDao(User param)
        {
            return new UserDao()
            {
                FamilyName = param.FamilyName,
                FirstName = param.FirstName,
                UserName = param.UserName,
                Email = param.Email,
                Age = param.Age,
                Gender = param.Gender,
                Bio = param.Bio
            };
        }

        /// <summary>
        /// Convert dao to param.
        /// </summary>
        /// <param name="dao">user dao</param>
        /// <returns>param</returns>
        private User daoToParam(UserDao dao)
        {
            return new User()
            {
                FamilyName = dao.FamilyName,
                FirstName = dao.FirstName,
                UserName = dao.UserName,
                Email = dao.Email,
                Age = dao.Age,
                Gender = dao.Gender,
                Bio = dao.Bio
            };
        }
    }
}