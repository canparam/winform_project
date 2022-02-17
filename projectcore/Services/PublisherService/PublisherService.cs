using projectcore.Database;
using projectcore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectcore.Services
{
    public class PublisherService : Base<Publishers>, IPublisher
    {
        public PublisherService(LibaryContext libary) : base(libary)
        {
        }
        public List<Publishers> GetActive()
        {
            var qery = Dbset.AsQueryable();

            return qery.Where(e => e.status == 0).ToList();
        }

        public Publishers GetFirstByName(string name)
        {
            var query = Dbset.AsQueryable();

            var pub = query.FirstOrDefault(e => e.name == name);

            return pub;
        }
    }
}
