using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // 1.Verilmish n ededinin 3-e ve 7-ye bolunub bolunmemesini tapmaq.
            //Divided(42);

            // 2.Verilmish n ve m ededlerinin her ikisi cutdurse n ve m ededlerinin cemini tapmaq tapmaq.
            // SumEvenNumbers(4, 6);

            // 3. Verilmis n ve m ededleri arasindaki tek ededlerin cemini tapmaq.
            // SumOddNumbers(1, 6);

            // 4. Verilmis arrayin icindeki tek ededlerin cemini tapin.

            //int[] arr = { 2, 3, 4, 5, 6, 9, 10 };
            //SumOddNumbersArr(arr);


            // 5. Verilmis arrayin icindeki cut ededlerin sayini tapmaq.

            //int[] arr = { 1, 3, 6, 8,10, 12,15 };
            //CountEvenNumbersArr(arr);


            // 6. Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapmaq.

            //PrimeCompositeNumber(5);


 


            static void Divided(int n)
            {


                if (n % 3 == 0 && n % 7 == 0)
                {
                    Console.WriteLine("Divided");
                }
                else
                {
                    Console.WriteLine("Not Divided");
                }
            }



            static void SumEvenNumbers(int n, int m)
            {

                int sum = 0;

                if (n % 2 == 0 && m % 2 == 0)
                {
                    sum = n + m;
                    Console.WriteLine(sum);
                }





                static void SumOddNumbers(int n, int m)
                {
                    int sum = 0;
                    for (int i = n; i < m; i++)
                    {
                        if (i % 2 == 1)
                        {
                            sum = sum + i;
                        }
                    }
                    Console.WriteLine(sum);
                }



                static void SumOddNumbersArr(int[] odd)
                {
                    int sum = 0;
                    for (int i = 0; i < odd.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum += odd[i];
                        }
                    }
                    Console.WriteLine(sum);
                }

                static void CountEvenNumbersArr(int[] even)
                {
                    int count = 0;
                    for (int i = 0; i < even.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count);
                }


                static void PrimeCompositeNumber(int n)
                {
                    int m;
                    int count = 0;
                    m = n / 2;
                    for (int i = 2; i <= m; i++)
                    {
                        if (n % i == 0)
                        {
                            Console.WriteLine("Composite");
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Prime");
                    }
                }


            }
        }
    }
}
