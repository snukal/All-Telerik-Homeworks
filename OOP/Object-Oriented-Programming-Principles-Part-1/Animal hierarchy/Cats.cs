namespace Animal_hierarchy
{
    using System;

    public class Cats : Animals, ISound
    {
        public Cats(string setName, Gender setGender, int setAge) : base(setAge, setName, setGender)
        {
            this.Age = setAge;
            this.Name = setName;
            this.Gender = setGender;
        }

        public override string ProduceSound()
        {
            return "Mew!";
        }
    }
}
