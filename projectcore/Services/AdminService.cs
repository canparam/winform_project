using Microsoft.EntityFrameworkCore;
using projectcore.Database;
using projectcore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectcore.Services
{
    public class AdminService : IBase<Admin>
    {
        private readonly LibaryContext libaryContext;
        private bool disposed = false;
        public AdminService(LibaryContext libary)
        {
            libaryContext = libary;
        }
        public void Delete(int ID)
        {
            Admin admin = this.libaryContext.Admin.Find(ID);
            this.libaryContext.Admin.Remove(admin);
            this.libaryContext.SaveChanges();
        }
        public IEnumerable<Admin> getAll()
        {
            return this.libaryContext.Admin.ToList();
        }

        public int Insert(Admin t)
        {
            this.libaryContext.Admin.AddAsync(t);
            this.libaryContext.SaveChanges();
            return  t.id;
        }

        public int InsertMany(List<Admin> t)
        {
            throw new NotImplementedException();
        }

      

        public bool Update( Admin t)
        {
            if (t == null) return false;
            this.libaryContext.Entry(t).State = EntityState.Modified;
            this.libaryContext.SaveChanges();
            return true;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.libaryContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

    }
}
