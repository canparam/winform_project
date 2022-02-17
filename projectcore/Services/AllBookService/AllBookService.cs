using projectcore.Database;
using projectcore.models.views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace projectcore.Services.AllBookService
{
    public class AllBookService : Base<AllBook>, IAllBookService
    {
        public AllBookService(LibaryContext libary) : base(libary)
        {

        }

        [Obsolete]
        public List<AllBook> GetAllActive(List<List<string>> paramsQuery)
        {
            string sql = @"select b.id,b.quantity,b.title,b.status,b.author,b.publisher,b.isbn, COUNT(i.book_id) as count from books as b 
                         left join issua_list as i ON b.id = i.book_id WHERE b.status = 0 AND b.quantity > 0";
            if (paramsQuery != null)
            {
                string sqlOut = ConvertConditions(paramsQuery);
                sql += sqlOut;

            }
            string p = sql + " group by b.title, b.id,b.isbn,i.book_id,b.quantity,b.author,b.publisher,b.status";
            var query = QueryRawSql(p,
                x => new AllBook
                {
                    id = (int)x[0],
                    quantity = (int)x[1],
                    title = (string)x[2],
                    status = (int)x[3],
                    author = (int)x[4],
                    publisher = (int)x[5],
                    isbn = (string)x[6],
                    count = (int)x[7]
                }).ToList();
            return query;
        }

        [Obsolete]
        public List<AllBook> GetAllBooks(List<List<string>> paramsQuery)
        {
            string sql = @"select b.id,b.quantity,b.title,b.status,b.author,b.publisher,b.isbn, COUNT(i.book_id) as count from books as b 
                         left join issua_list as i ON b.id = i.book_id WHERE b.status != 1";
            if (paramsQuery != null)
            {
                string sqlOut = ConvertConditions(paramsQuery);
                sql += sqlOut;

            }
            string p = sql + " group by b.title, b.id,b.isbn,i.book_id,b.quantity,b.author,b.publisher,b.status";
            var query = QueryRawSql(p, 
                x => new AllBook { 
                    id = (int)x[0],
                    quantity = (int)x[1], 
                    title = (string)x[2],
                    status = (int)x[3], 
                    author = (int)x[4],
                    publisher = (int)x[5],
                    isbn = (string)x[6],
                    count = (int)x[7]
                }).ToList();
            return query;
        }

        [Obsolete]
        public AllBook GetFistById(int id)
        {
            string sql = @"select b.id,b.quantity,b.title,b.status,b.author,b.publisher,b.isbn, COUNT(i.book_id) as count from books as b 
                         left join issua_list as i ON b.id = i.book_id WHERE b.status = 0 AND b.id = " + id + " group by b.title, b.id,b.isbn,i.book_id,b.quantity,b.author,b.publisher,b.status";
            var query = QueryRawSql(sql, x => new AllBook
            {
                id = (int)x[0],
                quantity = (int)x[1],
                title = (string)x[2],
                status = (int)x[3],
                author = (int)x[4],
                publisher = (int)x[5],
                isbn = (string)x[6],
                count = (int)x[7]
            }).First();

            return query;
        }
    }
}
