namespace Animal_hierarchy
{
    using System;

    public class Kitten : Cats, ISound
    {
        public Kitten(string setName, int setAge) : base(setName, Gender.Female, setAge)
        {
            this.Name = setName;
            this.Age = setAge;
        }
    }
}
