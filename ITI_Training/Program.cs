using System;

namespace ITI_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.Write("Input 5 elements in the array :\n");
            for(int i=0; i<5; i++)
            {
                Console.Write("element - {0} : ",i);

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(Maximum(arr));

        }

        public static int Maximum(int[] numbers)
        {
            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= max)
                {
                    max = numbers[i];
                }

            }

            return max;
        }
    }
}
