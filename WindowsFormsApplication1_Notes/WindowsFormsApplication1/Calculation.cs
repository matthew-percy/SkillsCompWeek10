using System;
using System.Threading;

namespace WindowsFormsApplication1
{
    class Calculation
    {
        private static int CK_Interval = 1000;
        public event Action CalculationFinished;
        public event Action<int> NewNumber;
        private Thread _t;

        public bool InUse { get; private set; }
        
        ~Calculation()
        {
            if(_t != null)
            _t.Abort();
        }
        public void CalculatePrimeNumbers()
        {
            InUse = true;
            _t = new Thread(test);
            _t.Start();
        }
        private void test()
        {
            for (int i = 2; (i <= 150); i++) //go through numbers 2 - 150
            {
                bool isPrime = true;
                for (int y = 2; y < i; y++) //go through all numbers preceeding the current number 
                {
                    if (i % y == 0) //if this happens (numbers evenly divide), it is not a prime number
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    if (NewNumber != null) NewNumber(i);
                    Thread.Sleep(CK_Interval);
                }
            }

            if (CalculationFinished != null)
            {
                CalculationFinished();
                InUse = false;
            }

        }
    }
}
