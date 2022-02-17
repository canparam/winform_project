using projectcore.Database;
using projectcore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectcore.Services.IssuesListService
{
    public class IssuesListService : Base<Issues_list>,IissuesListService
    {
        public IssuesListService(LibaryContext libary) : base(libary)
        {
            
        }

        public List<Issues_list> GetBookById(int id)
        {
            var query = Dbset.AsQueryable();

            var Lists = query.Where(e => e.issue_id == id).ToList();
            return Lists;
        }
    }
}
