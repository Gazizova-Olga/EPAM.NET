using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class User
    {
        private static int index = 0;
        public int Id { get; private set; }
        public string firstName;
        public string lastName;
        public DateTime birthdate;
        public List<Award> Awards { get; set; } = new List<Award>();
        public string AwardsStr
        {
            get
            {
                var str = String.Empty;
                foreach (var award in Awards)
                {
                    str += award.Name + "; ";
                }
                return str;
            }
            private set
            {

            }
        }

        public User()
        { }

        public void AddAward(IEnumerable<Award> awards)
        {
            if (awards == null)
                throw new ArgumentException("Award");

            foreach (var award in awards)
            {
                AddAward(award);
            }
        }

        public void AddAward(Award award)
        {
            if (award == null)
                throw new ArgumentException("Award");

            Awards.Add(award);
        }

        public void RemoveAward(Award award)
        {
            if (award == null)
                throw new ArgumentException("Award");

            Awards.Remove(award);
        }



        public User(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Id = index;
            index++;
        }

        public User(string firstName, string lastName, DateTime birthdate, List<Award> awards) : this(firstName, lastName, birthdate)
        {
            Awards = awards;
        }

        public User(int id, string firstName, string lastName, DateTime birthdate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
        }


        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ValidateString(ref firstName, value, "Incorrect first name");
                }
                else
                {
                    throw new Exception("Incorrect first name");
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ValidateString(ref lastName, value, "Incorrect last name");
                }
                else
                {
                    throw new Exception("Incorrect last name");
                }
            }
        }


        private void ValidateString(ref string str, string value, string ex)
        {
            if (value.Length > 50)
            {
                throw new Exception(ex);
            }
            value = value.Trim();
            for (int i = 0; i < value.Length; i++)
            {
                if (!(char.IsLetter(value[i]) || value[i] == '-' || value[i] == ' '))
                {
                    throw new Exception(ex);
                }
            }
            str = value;
        }

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                if (value <= DateTime.Now && DateTime.Now.Year - value.Year <= 150)
                {
                    birthdate = value;
                }
                else
                {
                    throw new Exception("Incorrect birthday");
                }
            }
        }

        public int Age
        {
            get
            {
                var ageDays = DateTime.Now - birthdate;
                return ageDays.Days / 365;
            }
            private set
            {

            }
        }
    }
}