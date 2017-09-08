using System;
using System.Globalization;
using System.Runtime.Remoting;

namespace Aikya_Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long x, y, i = 10, j , leftHalf, rightHalf, square, digitSum, num,sqr_number,countDigits=0;
            bool thereIsNumber = false;
			
            try
			{
                Console.WriteLine("Enter the range of non negative integers ");
                 x = long.Parse(Console.ReadLine());
                 y = long.Parse(Console.ReadLine());

                while (x <= y)
                {
                    num = x;
                    square = num * num;
                    sqr_number = square;


                    while (!isZero(sqr_number))
                    {
                        countDigits++;
                        sqr_number = sqr_number / 10;

                    }

                    if (num == 1)
                    {
                        Console.WriteLine("{0} is Kaprekar Number", num);
                        thereIsNumber = true;
                    }

                        for (j = 1; j < countDigits; j++)
                        {
                            
                                leftHalf = square / i;
                                rightHalf = square % i;


                            if(isnonzero(rightHalf))
                            {
                            	digitSum = leftHalf + rightHalf;

                            	if (digitSum == x)
                            	{
                            		Console.WriteLine("{0} is Kaprekar Number", num);
                            		thereIsNumber = true;
                                    break;
                            	}


                            }
                            i = i * 10;
                        }
                        countDigits = 0;
                        i = 10;
                        j = 1;
                        x++;
                    }


                if (thereIsNumber == false)
                    Console.WriteLine("No Kaprekar Numbers found in the given range");
                
            }
            catch(DivideByZeroException e){
                Console.WriteLine(e);
            }
            catch(System.OverflowException ){
                Console.WriteLine("Please enter non negative integers range");
            }


        }
        public static bool isnonzero(long rightHalf)
        {
            if (rightHalf != 0)
                return true;
            else
                return false;
        }

        public static bool isZero(long sqr_number)
        {
            if (sqr_number == 0)
                return true;
            else
                return false;
        }
    }
}
