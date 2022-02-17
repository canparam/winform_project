using projectcore.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace projectcore.Services
{
    public interface IGenreService : IBase<Genres>
    {
        Genres GetFirstByName(string name);
        List<Genres> GetActive();

    }
}
