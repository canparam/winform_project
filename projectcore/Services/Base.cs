using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using projectcore.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace projectcore.Services
{
    public class Base<T> : IBase<T> where T : class
    {
        protected DbSet<T> Dbset;
        protected readonly LibaryContext libaryConText;
        private bool disposed = false;
        private int id;

        
        public Base(LibaryContext libary)
        {
            libaryConText = libary;
            Dbset = libary.Set<T>();
        }
        public void Delete(T t)
        {
            Dbset.Remove(t);
            libaryConText.SaveChanges();
        }

        public IEnumerable<T> getAll()
        {
            return Dbset.AsQueryable();
        }

        public T Insert(T t)
        {
            Dbset.Add(t);
            libaryConText.SaveChanges();
            return t;
        }

        public int InsertMany(List<T> t)
        {
            Dbset.AddRange(t);
            int rows = libaryConText.SaveChanges();
            return rows;
        }

        public bool Update(int id,T t)
        {
            if (t == null) return false;
            var entry = Dbset.Find(id);
            libaryConText.Entry(entry).CurrentValues.SetValues(t);
            libaryConText.SaveChanges();
            return true;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    libaryConText.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        public T GetById(int id)
        {
            var entry =  Dbset.Find(id);

            T t = (T)libaryConText.Entry(entry).CurrentValues.ToObject();
            return t;
        }

        [Obsolete]
        public async Task<bool> InsertProcedureAsync(string StoredProcedure,string param, List<SqlParameter> parameters)
        {
            var SQL = "exec " + StoredProcedure + param;
            await libaryConText.Database.ExecuteSqlCommandAsync(SQL, parameters);
            return true;
        }

        [Obsolete]
        public  List<T> QueryRawSql(string queryString, Func<DbDataReader, T> map)
        {
            var command = libaryConText.Database.GetDbConnection().CreateCommand();
            command.CommandText = queryString;
            command.CommandType = CommandType.Text;
            libaryConText.Database.OpenConnection();

            using (var result = command.ExecuteReader())
            {
                var entities = new List<T>();

                while (result.Read())
                {
                    entities.Add(map(result));
                }

                return entities;
            }

        }

        public string ConvertConditions(List<List<string>> query)
        {
            string sql = " ";
            
            foreach(var k in query)
            {
                switch (k[1])
                {
                    case "like":
                        sql += " AND " + k[0] + " like " + "'%" + k[2] + "%'";
                        break;
                    case "=":
                        sql += " AND " + k[0] + " = " + k[2];
                        break;
                    case ">":
                        sql += " AND " + k[0] + " > " + k[2];
                        break;
                    case "<":
                        sql += " AND " + k[0] + " < " + k[2];
                        break;
                }
            }

            return sql;
        }
    }
}
