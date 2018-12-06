using System;
using Depart.DAL;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depart.BLL
{
    public class AwardBL
    {
        private readonly IAwardDAO awardsDAO;

        public AwardBL()
        {
            
            awardsDAO = new AwardSqlDAO();
        }

        public IEnumerable<Award> InitList()
        {
            
            return GetList();
        }

        public IEnumerable<Award> SortAwardsByTitleAsc()
        {
            return (from s in GetList()
                    orderby s.Name ascending
                    select s).ToList();
        }

        public IEnumerable<Award> SortAwardsByTitleDesc()
        {
            return (from s in GetList()
                    orderby s.Name descending
                    select s).ToList();
        }


        public void Add(string title, string description)
        {
            Award award = new Award(title, description);
            Add(award);
        }

        public void Add(Award award)
        {
            if (award == null)
                throw new ArgumentException("award");

            awardsDAO.Add(award);
        }

        public void Remove(Award award)
        {
            if (award == null)
                throw new ArgumentException("award");

            awardsDAO.Remove(award);
        }

        public void Edit(Award award)
        {
            if (award == null)
                throw new ArgumentException("award");

            awardsDAO.Edit(award);
        }

        public void Remove(Award award, UserBL users)
        {
            this.Remove(award);
            foreach (var user in users.GetList())
            {
                user.RemoveAward(award);
            }
        }

        public List<Award> GetList()
        {
            return awardsDAO.GetList();
        }
    }
}