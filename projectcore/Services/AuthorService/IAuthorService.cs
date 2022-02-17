using projectcore.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services.AuthorService
{
    public interface IAuthorService : IBase<Authors>
    {
        Authors GetFirstByName(string name);
        List<Authors> GetActive();

    }
}
