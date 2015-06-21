namespace GSMove
{
    using System;

    public class GSMTest
    {
        GSM[] arrayOfGSMs = new GSM[19];

        public GSM[] CreateGSMs()
        {
            for (int i = 0; i < 10; i++)
            {
                arrayOfGSMs[i] = new GSM("Samsung", "G900F", 100 + i, "Svilen Ukalski");
            }
            return arrayOfGSMs;
        }

    }
}
