using projectcore.models;
using projectcore.models.views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace projectcore.Services.BookService
{
    public interface IBookService : IBase<Book>
    {
        bool FindBySN(string sn);

    }
}
