

namespace BeforeDSA_Program.Phase1;

public class Phase1_BeforeDSA
{
    public static void Main(string[] args)
    {
        PrintNum1to10();
    }
    //1. Print all numbers from 1 to 10 using a loop.

    public static void PrintNum1to10()
    {
        int i = 1;

        while (i <= 10){
            i++;
            Console.WriteLine(i);
        }


    }
}
