using projectcore.models;
using projectcore.models.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services.IssueService
{
    public interface IissueService : IBase<Issues>
    {
        bool InsertIssue(List<Book> books, Users user, DateTime time);
        bool ReturnBook(int id);
        bool NotReturn(int id);
        bool Lost(int id);

    }
}
