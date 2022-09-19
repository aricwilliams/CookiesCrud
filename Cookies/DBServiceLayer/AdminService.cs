using Cookies.Data;
using Cookies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cookies.DBServiceLayer
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext _db;
        public AdminService(ApplicationDbContext db)
        {
            _db = db;
        }

        public void CreateCookie(AdminCookies adminCookies)
        {

            _db.AdminCookies.Add(adminCookies);
        }

        public void DeleteCookie(int Id)
        {
            AdminCookies cookie = _db.AdminCookies.Find(Id);
            _db.AdminCookies.Remove(cookie);
        }

        public IEnumerable<AdminCookies> GetAllCookies()
        {
            return _db.AdminCookies.ToList();
        }

        public AdminCookies GetCookieByID(int id)
        {
            return _db.AdminCookies.Find(id);
        }


        public void Save()
        {
            _db.SaveChanges();
        }

        public void UpdateRecipe(AdminCookies cookie)
        {
            _db.Entry(cookie).State = EntityState.Modified;
            if(cookie.CookiePhoto == null)
            {
                _db.Entry(cookie).Property(o => o.CookiePhoto).IsModified = false;

            }
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //public AdminImage GetCookieByPhotoID(int cookieId)
        //{
        //    return _db.AdminImage.Find(cookieId);
        //}

        //public IEnumerable<AdminImage> GetAllCookieImages()
        //{
        //    return _db.AdminImage.ToList();
        //}

        //public void CreateCookieImage(AdminImage adminCookiesImage)
        //{
        //    _db.AdminImage.Add(adminCookiesImage);
        //}

        //public void DeleteCookieImage(int ID)
        //{
        //    AdminImage cookieImage = _db.AdminImage.Find(ID);
        //    _db.AdminImage.Remove(cookieImage);
        //}

    }
}
