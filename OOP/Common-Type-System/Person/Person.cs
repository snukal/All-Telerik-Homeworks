namespace PersonTask
{
    using System;
    using System.Linq;
    using System.Text;

    class Person
    {
        private string name;
        private uint? age;
        public Person(string name, uint? age = null)
        {
            this.Name = name;
            if (age.HasValue)
            {
                this.Age = age.Value;
            }
        }
        public uint? Age { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Names cannot be empty");
                }
                this.name = value;
            }
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("This Person's name is {0}.", this.Name);
            if (this.Age.HasValue)
            {
                builder.AppendFormat(" This person is {0} years old.", this.Age);
            }
            else
            {
                builder.Append(" Age was not specified.");
            }
            return builder.ToString();
        }
    }
}
