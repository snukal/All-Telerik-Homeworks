namespace DefiningClassesPartII_1_
{
    using System;
    public class GenericMain
    {

        public static void Main()
        {
            GenericList<int> testList = new GenericList<int>(5);

            for (int i = 0; i < 4; i++)  
            {
                testList.Add(i + 1);
                Console.WriteLine("Element: {0}, Count: {1} Capacity: {2}",
                    testList[i], testList.Count, testList.Capacity);
            }
            for (int i = 0; i < testList.Count; i += 2)
            {
                testList.InsertAt(i, 1000);
                Console.WriteLine(testList.ToString());
            }

            for (int i = testList.Count-2; i > 0 ; i -=2)
            {
                testList.RemoveAt(i);
                Console.WriteLine(testList.ToString());
            }

            Console.WriteLine(testList);
            Console.WriteLine(testList.Min());
            Console.WriteLine(testList.Max());
        }
    }
}