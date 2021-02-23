using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPIExample.Database.User
{
    /// <summary>
    /// User repository
    /// </summary>
    public class UserRepository
    {
        /// <summary>
        /// Presudo database.
        /// </summary>
        private List<UserDao> innerDatabase = createPseudoDatabase();

        /// <summary>
        /// Fetch all users.
        /// </summary>
        /// <returns>all users</returns>
        public IEnumerable<UserDao> Fetch()
        {
            return innerDatabase;
        }

        /// <summary>
        /// Find user by id.
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>target user</returns>
        public UserDao Find(int id)
        {
            return innerDatabase.Where(x => x.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="user">user info</param>
        public void Create(UserDao user)
        {
            // create.
        }

        /// <summary>
        /// Update user.
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="user">user info</param>
        public void Update(int id, UserDao user)
        {
            // update
        }

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="id">user id</param>
        public void Delate(int id)
        {
            // delete
        }

        /// <summary>
        /// Craete Pseudo-Database.
        /// </summary>
        /// <returns>pseudo database</returns>
        private static List<UserDao> createPseudoDatabase()
        {
            var now = DateTime.Now;
            var db = new List<UserDao>();

            foreach(var cnt in Enumerable.Range(1, 10))
            {
                db.Add(new UserDao()
                {
                    Id = cnt,
                    FamilyName = "John_" + cnt,
                    FirstName = "Doe_" + cnt,
                    UserName = "exam-user-" + cnt,
                    Email = "webapi-sample-" + cnt + "@example.com",
                    Age = 10 + (uint)cnt,
                    Bio = "Hello world!!",
                    CreatedAt = now,
                    UpdatedAt = now
                });
            }

            return db;
        }
    }
}