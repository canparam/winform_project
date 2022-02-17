using Microsoft.EntityFrameworkCore;
using projectcore.Database;
using projectcore.models;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using projectcore.models.views;
using System.Linq;

namespace projectcore.Services.BookService
{
    public class BookService : Base<Book>, IBookService
    {
        public BookService(LibaryContext libary) : base(libary)
        {
           
        }
        public bool FindBySN(string sn)
        {
            var query = Dbset.AsQueryable();

            var b = query.FirstOrDefault(e => e.isbn.Equals(sn));
            if (b == null)
            {
                return false;
            }
            return true;
        }

       
    }
}
