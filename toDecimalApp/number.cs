using System;
namespace toDecimalApp
{
    class Number
    {
        public int system;
        public int lenght;
        public string? number;
        public int getDecimal()
        {
            char[] deciPos = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int[] nums = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                if (char.GetNumericValue(number, i) != -1.0)
                {
                    nums[i] = (int)char.GetNumericValue(number, i);
                }
                else
                {
                    if (system > 10)
                    {
                        nums[i] = Array.IndexOf(deciPos, char.ToUpper(number[i])) + 10;
                        //if (nums[i] == -1 || nums[i] > system)
                        //{
                        //    Console.WriteLine("Error you have entered an invalid number!!");
                        //    Console.Write("Do you want to continiue (Y/N)? : ");
                        //    if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
                        //    {
                        //        Program.Main();
                        //    }
                        //}
                    }
                }
            }
            int decimalVal = 0;
            for (int i = lenght - 1, j = 0; i >= 0; i--, j++)
            {
                decimalVal += (int)(nums[i] * Math.Pow(system, j));
            }
            return decimalVal;
        }
    }
}
