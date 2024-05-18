using PlanSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSystem.Controllers
{
    internal class Settings : IDisposable
    {
        private readonly MainDbContext _db;
        public Settings()
        {
            _db = new MainDbContext();
        }

        #region Property Types
        public bool AddTypes(string name)
        {
            try
            {
                _db.Types.Add(new() { Name = name });
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateTypes(PropertyType type)
        {
            try
            {
                _db.Types.Update(type);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<PropertyType> GetTypes()
        {
            try
            {
                return _db.Types.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Categories
        public bool AddCategory(string name)
        {
            try
            {
                _db.Categories.Add(new() { Name = name });
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateCategory(PropertyCategories cat)
        {
            try
            {
                _db.Categories.Update(cat);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<PropertyCategories> GetCategories()
        {
            try
            {
                return _db.Categories.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
