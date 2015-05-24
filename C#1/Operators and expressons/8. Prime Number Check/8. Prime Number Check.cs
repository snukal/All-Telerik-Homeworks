using System;

//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

class PrimeNumberCheck
{
    static void Main()
    {

        Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        if (number == 1) //1 is not a prime number!
        {                //check if the number is equal to 1 
            Console.WriteLine("This number is not prime. It is a special number!");
        }
        else
        {
            int PrimeCount = 0; // count how many times the number is divided

            for (int i = 1; i < number; i++) //loop rising to the entered number
            {
                if (number % i == 0)// check if the number has residue equal to 0
                {
                    PrimeCount++;// if the residue is equal to 0 pomp up PrimeCount with 1
                }
            }
                bool IsPrime = true; // set by default IsPrime to be true

                if (PrimeCount > 2) // check if the number is divided only twice by it selves and by 1
                {
                    IsPrime = false; // if the number is divided more than twice 
                }
                Console.WriteLine("The number is prime ---> " + IsPrime);
			
        }
    }
}
