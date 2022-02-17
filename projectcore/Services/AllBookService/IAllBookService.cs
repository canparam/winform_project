using projectcore.models.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services.AllBookService
{
    public interface IAllBookService : IBase<AllBook>
    {
        List<AllBook> GetAllBooks(List<List<string>> paramsQuery);
        List<AllBook> GetAllActive(List<List<string>> paramsQuery);
        AllBook GetFistById(int id);

    }
}
