using System;
class Program
{
    static void Main()
    {

        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
         
        int sum = 0;
        int count =0;
        int tempSum = 0;
        Console.Write("The sequence of elements with sum 11 are: ");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i ;j < arr.Length; j++)
            {
                
                if (tempSum < 11)
                {
                    tempSum += arr[j];
                    
                    count ++;
                }
                else if (tempSum>11)
                {
                    count = 0;
                    tempSum = 0;
                    break;
                }
                else if (tempSum == 11)
                {
                    int[] arrElem = new int[count];
                    for (int p = i; p < j; p++)
                    {
                        arrElem[p-i] = arr[p];
                        Console.Write(arrElem[p - i]);
                        Console.Write(", ");
                        
                    }
                    sum = tempSum;
                    
                    break;
                    
                }
            }
        }
        Console.WriteLine();
    }
}
