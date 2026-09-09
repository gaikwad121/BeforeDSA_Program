//using System.Security.Cryptography.X509Certificates;

//namespace BeforeDSA_Program.Phase1;

//public class Phase1_BeforeDSA
//{
//    public static void Main(string[] args)
//    {
//        PrintNum1to10();
//        printNum10to1();
//        printSumOfEvenNum();

//        Console.ReadLine();
//    }

//    // 1. Print all numbers from 1 to 10 using a loop.
//    public static void PrintNum1to10()
//    {
//        int i = 1;

//        while (i <= 10)
//        {
//            Console.WriteLine(i);
//            i++;
//        }
//    }
//    //2. Print numbers from 10 down to 1 in reverse order.
//public static void printNum10to1(){
//        int i = 10;
//        while (i >= 1)
//        {
//            Console.WriteLine(i);
//            i--;
//        }
//        //3. Print all even numbers between 1 and 100.

//        Public static void printEvenNum()
//        {
//            int i = 1;
//            while (i <= 100)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine(i);
//                }
//                i++;
//            }
//        }
//       // 4.Print all odd numbers between 1 and 100.
//       Public static void printOddNum()
//        {
            
//            int i = 1;
//            while (i <= 100)
//            {
//                if (i % 2 != 0)
//                {
//                    Console.WriteLine(i);
//                }
//                i++;
//            }
//        }
//        //5. Print the multiplication table of a given number from n × 1 to n ×10.

//        Public static void printMulTable()
//        {
//            int i = 1;
//            Console.WriteLine("Enter any number");
//            int n = Convert.ToInt32(Console.ReadLine());
//            while (i <= 10)
//            {

//                Console.WriteLine($"{n} x {i} = {n * i}");
//                i++;
//            }
//        }
//        //7. Calculate the sum of all even numbers from 1 up to n.

//        Public static void printSumOfEvenNum()
//        {
//            int i = 1;
//            int sum = 0;
//            Console.WriteLine("Enter the nth value : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            while (i <= n)
//            {
//                if (i % 2 == 0)
//                {
//                    sum += i;
//                }
//                i++;
//            }
//            Console.WriteLine(sum);
//        }
//    }
//    //8. Calculate the sum of all odd numbers from 1 up to n.


//    public static void printsumOfOddNum()
//    {
//        int i = 1;
//        int sum = 0;
//        Console.WriteLine("Enter the n value");
//        int n = Convert.ToInt32(Console.ReadLine())
//; while (i <= n)
//        {
//            if (i % 2 != 0)
//            {
//                sum += i;
//            }
//            i++;
//        }
//        Console.WriteLine(sum);
//    }
//}
//            //9. Calculate and print the factorial of a given number.

//public static FactorialOfNum()
//    {
//        double factorial = 1;
//        int i = 1;
//        int num = 5;
//        while (i <= num)
//        {
//            factorial *= i;
//            i++;
//        }
//        Console.WriteLine(factorial);

//    }
//}
////10. Find and print the product of all digits of a given number.
//public static void productOfDigits()
//{
  
//    int i = 1;

//    int pro = 1;
//    int n = 1234;
//    while (n != 0)
//    {
//        int product = n % 10;
//        pro = product * pro;
//        n /= 10;
//    }
//    Console.WriteLine(pro);
//}
//}
//// //11. Count and print the total number of digits in a given number.
//public static void countOfDigits() { 
//        int num = 12345;
//int count = 0;

//while (num != 0)
//{
//    int n = num % 10;
//    count++;
//    num /= 10;
//}
//Console.WriteLine(count);
//    }
//}
//    //12. Reverse the given number and print the reversed value.

//public static void RevNumber()
//{
//    int num = 1234;
//    int rev = 0;
//    int i = num;
//    while (num != 0)
//    {
//        rev = rev * 10 + num % 10;
//        num /= 10;
//    }
//    Console.WriteLine(rev);
//}
//}
//public static void CheckPalindrome()
//{
//    //13. Check whether the given number is a palindrome.
//    int rev = 0;
//    int num = 121;
//    int temp = num;
//    while (num != 0)
//    {
//        rev = rev * 10 + num % 10;
//        num /= 10;
//    }
//    if (temp == rev)
//    {
//        Console.WriteLine("It's palindrome number");
//    }
//    else
//    {
//        Console.WriteLine("It's not a palindrome number");
//    }
//      //14. Find and print the sum of digits of the given number.

//    Public static void CalculateSumOfDigits()
//    {
//        int num = 12345;
//        int sum = 0;
//        while (num != 0)
//        {
//            int digit = num % 10;
//            sum += digit;
//            num /= 10;
//        }
//        Console.WriteLine(sum);
//    }
//}
//    }
//}
//    //15. Check whether the given number is an Armstrong number.

//public static void CheckArmStrongNumber()
//{
//    int sum = 0;
//    int num = 153;
//    int temp = num;
//    while (num != 0)
//    {
//        int n = num % 10;
//        sum = sum + n * n * n;
//        num /= 10;
//    }
//    if (temp == sum)
//    {
//        Console.WriteLine("It's armstrongnumber");
//    }
//    else
//    {
//        Console.WriteLine("It's not armstrongnumber");
//    }
//}
//public static void CheckPerfectNumber()
//{
//    //16. Check whether the given number is a Perfect number.
//    int i = 1;
//    int sum = 0;
//    int num = 6;
//    int temp = num;
//    while (i < num)
//    {
//        if (num % i == 0)
//        {
//            sum += i;
//        }
//        i++;
//    }
//    if (temp == sum)
//    {
//        Console.WriteLine("It's perfect number");
//    }
//    else
//    {
//        Console.WriteLine("It's not perfect Number");
//    }
//}
//}

//}

    