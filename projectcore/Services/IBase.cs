using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace projectcore.Services
{
    public interface IBase<T> : IDisposable  where T : class
    {
        public T Insert(T t);
        public int InsertMany(List<T> t);
        public IEnumerable<T> getAll();
        public bool Update(int id, T t);
        public void Delete(T t);
        public T GetById(int id);
        public Task<bool> InsertProcedureAsync(string StoredProcedure,string param, List<SqlParameter> parameters);
        public List<T> QueryRawSql(string query, Func<DbDataReader, T> map);
        public string ConvertConditions(List<List<string>> query);

    }
}
