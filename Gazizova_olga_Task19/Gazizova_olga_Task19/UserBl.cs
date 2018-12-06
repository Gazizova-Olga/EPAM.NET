using Depart.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depart.BLL
{
    public class UserBL
    {
        private readonly IUserDAO usersDAO;

        public UserBL()
        {
            //usersDAO = new UserDAO();
            usersDAO = new UserSqlDAO();
        }

        public IEnumerable<User> InitList()
        {
            //Add(new User("Иван", "Иванов", DateTime.Parse("2010.10.10")));
            //Add(new User("Петр", "Петров", DateTime.Parse("2008.08.08")));
            return GetList();
        }

        public IEnumerable<User> SortUsersByFirstNameAsc()
        {
            return (from s in GetList()
                    orderby s.FirstName ascending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByFirstNameDesc()
        {
            return (from s in GetList()
                    orderby s.FirstName descending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByAgeDesc()
        {
            return (from s in GetList()
                    orderby s.Age ascending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByAgeAsc()
        {
            return (from s in GetList()
                    orderby s.Age descending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByLastNameAsc()
        {
            return (from s in GetList()
                    orderby s.LastName ascending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByLastNameDesc()
        {
            return (from s in GetList()
                    orderby s.LastName descending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByBirthdateAsc()
        {
            return (from s in GetList()
                    orderby s.Birthdate ascending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByBirthdateDesc()
        {
            return (from s in GetList()
                    orderby s.Birthdate descending
                    select s).ToList();
        }

        public void Add(string firstName, string lastName, DateTime birthdate, List<Award> awards)
        {
            User user = new User(firstName, lastName, birthdate, awards);
            Add(user);
        }

        public void Add(User user)
        {
            if (user == null)
                throw new ArgumentException("user");

            usersDAO.Add(user);
        }

        public void Edit(User user)
        {
            if (user == null)
                throw new ArgumentException("user");

            usersDAO.Edit(user);
        }

        public void Remove(User user)
        {
            if (user == null)
                throw new ArgumentException("user");

            usersDAO.Remove(user);
        }

        public IEnumerable<User> GetList()
        {
            return usersDAO.GetList();
        }
    }
}