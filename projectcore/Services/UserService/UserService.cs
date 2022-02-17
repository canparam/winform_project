using Microsoft.EntityFrameworkCore;
using projectcore.Database;
using projectcore.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectcore.Services
{
    public class UserService : Base<Users>, IUserService
    {
        public UserService(LibaryContext libary) : base(libary)
        {
        }

        public List<Users> GetActive()
        {
            var qery = Dbset.AsQueryable();

            return qery.Where(e => e.status == 0).ToList();
        }

        public Users GetById(int id)
        {
            var query = Dbset.AsQueryable();

            var user = query.FirstOrDefault(e => e.id == id);

            return user;
        }
       
    }
}
