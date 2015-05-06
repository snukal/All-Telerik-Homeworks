namespace Animal_hierarchy
{
    using System;

    public class Tomcat : Cats, ISound
    {
        public Tomcat(string setName, int setAge) : base(setName, Gender.Male, setAge)
        {
            this.Name = setName;
            this.Age = setAge;
        }
    }
}
