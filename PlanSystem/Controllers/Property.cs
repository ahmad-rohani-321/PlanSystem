using Microsoft.EntityFrameworkCore;
using PlanSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSystem.Controllers
{
    internal class Property : IDisposable
    {
        private readonly MainDbContext _db;
        public Property()
        {
            _db = new MainDbContext();
        }
        public bool AddProperty(PropertyInfo property, RegistrationInfo registration)
        {
            try
            {
                _db.Properties.Add(property);
                _db.SaveChanges();
                registration.PropertyId = property.id;
                _db.Registration.Add(registration);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool UpdatePropety(PropertyInfo property, RegistrationInfo registration)
        {
            try
            {
                _db.Update(property);
                registration.Property = null;
                _db.Update(registration);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePropety(int resgtrationId)
        {
            try
            {
                var reg = _db.Registration.SingleOrDefault(x => x.Id == resgtrationId);
                var prop = _db.Properties.SingleOrDefault(x => x.id ==  reg.PropertyId);
                _db.Properties.Remove(prop);
                _db.Registration.Remove(reg);
                _db.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<RegistrationInfo> GetList()
        {
            try
            {
                return [.. _db.Registration
                    .Include(x => x.Property)
                    .Include(x => x.Type)
                    .Include(x => x.Category)];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
