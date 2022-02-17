using projectcore.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services
{
    public interface IAdminService : IBase<Admin>
    {
        Admin CheckLogin(string username, string password);
    }
}
