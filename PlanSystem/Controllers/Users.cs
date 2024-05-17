using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSystem.Controllers
{
    internal class Users : IDisposable
    {
        private readonly MainDbContext _db;
        public Users()
        {
            _db = new MainDbContext();
        }

        public bool AddUser(string username, string password)
        {
            try
            {
                var user = new Entity.Users()
                {
                    IsReadonly = true,
                    Password = password,
                    UserName = username,
                };
                _db.Users.Add(user);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateUser(int id, string username, string password)
        {
            try
            {
                var user = _db.Users.FirstOrDefault(x => x.Id == id);
                user.UserName = username;
                user.Password = password;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteUser(Entity.Users user)
        {
            try
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
