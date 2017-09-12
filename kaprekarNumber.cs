 //@author - Sankalp Saxena

using System;
namespace AikupperLimita_Project
{
    class KaprekarNumber
    {
        public static void Main(string[] args)
        {
		bool foundKaprekar = false;	

                Console.WriteLine("Enter the range of non negative integers ");
               
                long.TryParse(Console.ReadLine(), out long lowerLimit);
		long.TryParse(Console.ReadLine(), out long upperLimit);

	        for (lowerLimit = 0; lowerLimit <= upperLimit; lowerLimit++) 
                {
                    long number = lowerLimit;
                    long square = number * number;
                    int countDigits = CountDigits(square);
                    long divisor = 1;
                  
                    for (long j = 1; j <= countDigits; j++)
                    {
                        long leftHalf = square / divisor;
                        long rightHalf = square % divisor;


                    if(rightHalf != 0 || square == number)
                    {
                        long digitSum = leftHalf + rightHalf;
	 		        if (digitSum == lowerLimit)
                        	{
                           		Console.WriteLine("{0} is Kaprekar Number", number);
                           		foundKaprekar = true;
                        	        break;
                           	}
                        }
    
                        divisor = divisor *  10;
                    }
                    countDigits = 0;
                    divisor = 1;
                 }


                if (foundKaprekar == false) {
     			Console.WriteLine("No Kaprekar Numbers found in the given range");
    		}
        } //Close to Main

        public static int CountDigits(long number)
        {
            int countDigits = 0;
	    while (number != 0)
            {
		countDigits++;
                number = number / 10;
	    }
            return countDigits;

	}
    }
}
