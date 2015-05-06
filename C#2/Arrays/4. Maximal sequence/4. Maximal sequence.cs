using System;

class MaxEqualElementsSequence
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int length = int.Parse(Console.ReadLine());//take the length of the array
        int[] theArray= new int[length];//decline the array
        int maxCount = 0;//number of the biggest sequence elements
        int currentCount = 1;//counting the number ot equal elements
        int sequenceStart = 0;
        for (int index = 0; index < length; index++)//loop to check every element of the array
        {
            Console.Write("Enter element {0}: ", index);
            theArray[index] = int.Parse(Console.ReadLine());//fill in every element of the array
            if (index != 0)//check if the loop is on the second element of the array
            {
                if (theArray[index] == theArray[index - 1])//check if we have an sequence
                {
                    currentCount++;//set currentCount + 1 until we have a break for the sequence
                }
                else//else :)
                {
                    currentCount = 1;// in situation when we doesn't have equal values we set currentCount to one
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;//if currentCount > maxCount so maxCount isn't the biggest any more... 
                    sequenceStart = index + 1 - maxCount;//set where te sequence starts
                }
            }
        }

        Console.Write("The maximal sequence of equal elements is: ");
        for (int index = sequenceStart; index < sequenceStart + maxCount; index++)//print the sequence
        {
            Console.Write("{0} ", theArray[index]);
        }
    }
}