using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {
        public IEnumerable<int> PrimeNumbers(int limit)
        {// қарапайым сандарды анықтау (тек өзіне бөлінетін сандар)
            for (int i = 1; i <= limit; i++)
            {
                bool isPrime = true; // сан алғашында қарапайым деп есептеледі және жүктеледі
                for (int j = 2; j < i; j++) // ол санды бөлуге циклді дайындайды
                {
                    if (i % j == 0) // ол сан тек өзіне ғана бөлінбесе массивтан алынып тасталынады 
                        //яғни ол өзіне және басқада санға бөлінсе алынып тасталынады
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)//қалған сандарды қарапайым деп есептейді
                {
                    yield return i;
                }
            } 
        }
    }
}