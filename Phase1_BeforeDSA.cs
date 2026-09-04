using System.Security.Cryptography.X509Certificates;

namespace BeforeDSA_Program.Phase1;

public class Phase1_BeforeDSA
{
    public static void Main(string[] args)
    {
        PrintNum1to10();
        printNum10to1();
        printSumOfEvenNum();

        Console.ReadLine();
    }

    // 1. Print all numbers from 1 to 10 using a loop.
    public static void PrintNum1to10()
    {
        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
    //2. Print numbers from 10 down to 1 in reverse order.
public static void printNum10to1(){
        int i = 10;
        while (i >= 1)
        {
            Console.WriteLine(i);
            i--;
        }
        //3. Print all even numbers between 1 and 100.

        Public static void printEvenNum()
        {
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
       // 4.Print all odd numbers between 1 and 100.
       Public static void printOddNum()
        {
            
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        //5. Print the multiplication table of a given number from n × 1 to n ×10.

        Public static void printMulTable()
        {
            int i = 1;
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            while (i <= 10)
            {

                Console.WriteLine($"{n} x {i} = {n * i}");
                i++;
            }
        }
        //7. Calculate the sum of all even numbers from 1 up to n.

        Public static void printSumOfEvenNum()
        {
            int i = 1;
            int sum = 0;
            Console.WriteLine("Enter the nth value : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
    //
    }