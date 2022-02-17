using projectcore.Database;
using projectcore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectcore.Services.AuthorService
{
    public class AuthorService : Base<Authors>,IAuthorService
    {
        public AuthorService(LibaryContext libary) : base(libary)
        {

        }
        public List<Authors> GetActive()
        {
            var qery = Dbset.AsQueryable();

            return qery.Where(e => e.status == 0).ToList();
        }
        public Authors GetFirstByName(string name)
        {
            var query = Dbset.AsQueryable();

            var pub = query.FirstOrDefault(e => e.name == name);

            return pub;
        }
    }
}
