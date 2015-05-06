namespace Students_and_workers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string setFistName, string setLastName)
        {
            this.FirstName = setFistName;
            this.LastName = setLastName;
        }

        public string FirstName 
        { 
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string LastName 
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }
    }
}
