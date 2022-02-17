using System;
using System.Collections.Generic;
using System.Text;
using projectcore.models;

namespace projectcore.Services
{
    public interface IPublisher : IBase<Publishers>
    {
        Publishers GetFirstByName(string name);
        List<Publishers> GetActive();


    }
}
