using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services
{
    public interface IBase<T> : IDisposable   
    {
        public  int Insert(T t);
        public int InsertMany(List<T> t);
        public IEnumerable<T> getAll();
        public bool Update(T t);
        public void Delete(int ID);
    }
}
