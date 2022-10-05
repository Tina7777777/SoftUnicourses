using System;

namespace _1.MoreEncrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] calculations = new int[n];

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                string text = Console.ReadLine();
                for (int j = 0; j < text.Length; j++)
                {
                    int code = (int)text[j];
                    if (text[j] == 'a' || text[j] == 'e' || text[j] == 'o' || text[j] == 'i' || text[j] == 'u' || text[j] == 'A' || text[j] == 'E' || text[j] == 'O' || text[j] == 'I' || text[j] == 'U')
                    {
                        code *= text.Length;
                    }
                    else
                    {
                        code /= text.Length;
                    }
                    sum += code;
                }
                calculations[i] = sum;
            }


            int temp;
            for (int i = 0; i < calculations.Length - 1; i++)

                for (int j = i + 1; j < calculations.Length; j++)

                    if (calculations[i] > calculations[j])
                    {
                        temp = calculations[i];
                        calculations[i] = calculations[j];
                        calculations[j] = temp;
                    }
            //Array.Sort(calculations);
            foreach (int numbers in calculations)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
