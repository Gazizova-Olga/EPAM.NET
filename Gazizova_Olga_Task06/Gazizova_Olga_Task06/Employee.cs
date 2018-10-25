using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task06
{
    class Employee: User
    {
        public DateTime EmploymentDate { get;set; }
        private string post;

        public string Post
        {
            get
            {
                return post;
            }
            set
            {               
                    ValidateName(ref post, value, "Incorrect post");
            }
        }

        private int workExp;
        public int WorkExperience
        {
            get
            {
                return workExp;
            }
             set
            {
                var days = DateTime.Now - EmploymentDate;
                workExp = days.Days / 365;
            }
        }

        public Employee(string firstName, string lastName, DateTime birthday, string post, DateTime employmentDate) : base(firstName, lastName, birthday)
        {
            Post = post;
            EmploymentDate = employmentDate;
        }

        public Employee(string firstName, string lastName, string middleName, DateTime birthday, string post, DateTime employmentDate) : base(firstName, lastName, middleName, birthday)
        {
            Post = post;
            EmploymentDate = employmentDate;
        }
    }
}
