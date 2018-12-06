using System;

namespace Entities
{
    public class Award
    {
        private static int index = 0;
        public int Id { get; private set; }
        private string name;


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Incorrect title");
                }
            }
        }

        public string Description { get; set; }

        public Award()
        { }

        public Award(int id)
        {
            Id = id;
        }
        public Award(string name)
        {
            Name = name;
            Id = index;
            index++;
        }

        public Award(string title, string description) : this(title)
        {
            Description = description;
        }

        public Award(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}