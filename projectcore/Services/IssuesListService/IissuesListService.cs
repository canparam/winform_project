using projectcore.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services.IssuesListService
{
    public interface IissuesListService : IBase<Issues_list>
    {
        List<Issues_list> GetBookById(int id);
    }
}
