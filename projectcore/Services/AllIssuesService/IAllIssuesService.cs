using projectcore.models.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services.AllIssuesService
{
    public interface IAllIssuesService : IBase<AllIssues>
    {
        List<AllIssues> GetAllIssues();
        List<AllIssues> GetIssuaesById(int id);
        List<AllIssues> GetIssuaesByUserID(int id);
    }
}
