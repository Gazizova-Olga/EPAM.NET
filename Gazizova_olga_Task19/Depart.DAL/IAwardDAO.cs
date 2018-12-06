using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depart.DAL
{
    public interface IAwardDAO
    {
        void Add(Entities.Award award);
        void Remove(Entities.Award award);
        void Edit(Entities.Award award);
        System.Collections.Generic.List<Entities.Award> GetList();
    }
}