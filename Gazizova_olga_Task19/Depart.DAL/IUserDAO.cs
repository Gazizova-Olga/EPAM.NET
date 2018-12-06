using System;
namespace Depart.DAL
{
    public interface IUserDAO
    {
        void Add(Entities.User user);
        void Remove(Entities.User user);
        void Edit(Entities.User user);
        System.Collections.Generic.IEnumerable<Entities.User> GetList();
    }
}