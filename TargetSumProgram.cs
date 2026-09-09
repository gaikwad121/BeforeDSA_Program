using System.Security.Cryptography.X509Certificates;

namespace BeforeDSA_Program.Phase1;

public class Phase1_BeforeDSA2
{
    public static void Main()
    {
        Console.WriteLine("Program started");

        int count = CountPairsWithSum(6);

        Console.WriteLine($"Target found: {count}.");
        int countTriplets = CountTripletsWithSum(6);
        Console.WriteLine($"Target found: {countTriplets}.");
        int uniqueNum = FindUniqueNumber();
        Console.WriteLine($"Unique number found : {uniqueNum}. ");
        int secondLargestNum = FindSecondLargestNumber();
        Console.WriteLine($"Second largest number found : {secondLargestNum}. ");
        int firstRepeatingNum = FindFirstRepeatingNumber();
        Console.WriteLine($"First repeating number found : {firstRepeatingNum}. ");
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
    //Given an array 'a' consisting of integers Return the first value that is repeating in this array. If  no value is being repeated return -1

    public static int FindFirstRepeatingNumber()
    {
        int[] arr = ArrayElementsValue();
        int ans = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    return arr[i];
                }
            }
        }
        return -1;
    }

        
    
    // Find the total number of triple in the arrays whose sum is equal to the given value x
    public static int CountTripletsWithSum(int target)
    {
        int count = 0;
        int[] arr = ArrayElementsValue();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    int sum = arr[i] + arr[j] + arr[k];
                    if (sum == target)
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }
    //Pattern : Array Manupulation
    //Find the Unique number given in array where all numbers are repeated twice except one number
    public static int FindUniqueNumber()
    {
        int[] arr = ArrayElementsValue();

        int ans = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    arr[i] = -1;
                    arr[j] = -1;
                }
            }
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > 0)
                {
                    ans = arr[j];
                }
            }
        }
        return ans;    }

    
    

    

    
    //Find the total number of pairs in the arrays whose sum is equal to the given value x
    public static int CountPairsWithSum(int target)
    {
       int [] arr= ArrayElementsValue();
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                int sum = arr[i] + arr[j];
                if (sum == target)
                {
                    count++;
                }
            }
        }
        return count;

    }

    // Find the second largest number in the array
    public static int FindSecondLargestNumber()
    {
        int[] arr = ArrayElementsValue();

        int max = int.MinValue;
        int secondMax = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != max && arr[i] > secondMax)
            {
                secondMax = arr[i];
            }
        }
        return secondMax;
    }


    public static int [] ArrayElementsValue()
    {
        Console.WriteLine("Enter the size of array");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Enter element : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
      
    }
}
