using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizova_Olga_Task06
{
    class User
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private DateTime birthday;
        public int Age
        {
            get
            {
                var age = 0;
                var ageDays = DateTime.Now - birthday;
                age = ageDays.Days / 365;
                return age;
            }
        }

        public User(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public User(string firstName, string lastName, string middleName, DateTime birthday) : this(firstName, lastName, birthday)
        {
            MiddleName = middleName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                ValidateName(ref firstName, value, "Incorrect first name");
            }
        }

        public string LastName
        {
            get
            {
                return LastName;
            }

            set
            {
                ValidateName(ref middleName, value, "Incorrect last name");
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                ValidateName(ref middleName, value, "Incorrect middle name");
            }
        }

        protected void ValidateName(ref string name, string value, string ex)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception(ex);
            }


            value = value.Trim();
            for (int i = 0; i < value.Length; i++)
            {
                if (!(char.IsLetter(value[i]) || value[i] == '-'))
                {
                    throw new Exception(ex);
                }
            }
            name = value;
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                if (value <= DateTime.Now)
                {
                    birthday = value;
                }
                else
                {
                    throw new Exception("Incorrect birthday");
                }
            }
        }
    }
}
