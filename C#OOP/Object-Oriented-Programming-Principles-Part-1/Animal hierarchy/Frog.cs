namespace Animal_hierarchy
{
    using System;

    public class Frog : Animals, ISound
    {
        public Frog(string setName, int setAge, Gender setGender) : base(setAge, setName, setGender)
        {
            this.Name = setName;
            this.Gender = setGender;
            this.Age = setAge;
        }

        public override string ProduceSound()
        {
            return "Kvak kvak :D!";
        }
    }
}
