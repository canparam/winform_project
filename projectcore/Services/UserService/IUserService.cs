using projectcore.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services
{
    public interface IUserService : IBase<Users>
    {
        Users GetById(int id);
        List<Users> GetActive();

    }
}
