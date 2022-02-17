using projectcore.Database;
using projectcore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectcore.Services
{
    public class AdminService : Base<Admin>, IAdminService
    {
        public AdminService(LibaryContext libary) : base(libary)
        {

        }

        public Admin CheckLogin(string username, string password)
        {
            var query = Dbset.AsQueryable();

            var user = query.FirstOrDefault(e => e.username.Equals(username) && e.password.Equals(password));

            return user;
        }
    }
}
