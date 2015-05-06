namespace Animal_hierarchy
{
    using System;

    public class Dog : Animals, ISound
    {
        public Dog(string setName, Gender setGender, int setAge) : base(setAge, setName, setGender)
        {
            this.Name = setName;
            this.Gender = setGender;
            this.Age = setAge;
        }

        public override string ProduceSound()
        {
            return "Lailailailaiiiiii!";
        }
    }
}
