using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Education.DAL;
using Education.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Education.Models.Users
{
    public class UserRepositoryImpl : UserRepository
    {
        private EducationContext db;


        public UserRepositoryImpl(EducationContext context)
        {
            this.db = context;
        }

        public int Create(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int Delete(int id)
        {
            try
            {
                User user = db.Users.Find(id);
                if (user != null)
                {
                    db.Users.Remove(user);
                }
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
                if (disposing)
                    db.Dispose();
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public List<User> getAllUsers()
        {
            try
            {
                return db.Users.ToList();
            }
            catch
            {
                throw new NullReferenceException();
            }
        }

        public User GetUser(int id)
        {
            return db.Users.Find(id);
        }

        public int Update(User user)
        {
           try {
               db.SaveChanges();
               return 1;
           } catch {
               throw;
           }
        }
    }
}