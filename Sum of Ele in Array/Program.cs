using System;
public class sumOfElementsInArray
{

    public static void Main(String[] args)
    {
        int i, n, sum = 0;
        Console.WriteLine("Program  For implementations  Addition of elements in Array");
        Console.WriteLine("Eneter the Size Of Array:: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Size Of Array is :: {0}", n);

        int[] arr = new int[n];
        for (i = 0; i < n; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            arr[i] = num;
        }
        Console.Write("Elements in Array => \t");

        for (i = 0; i < n; i++)
        {
            Console.Write("\t {0}", arr[i]);
        }

        for (i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("\nAddition of eleemnts in Array =>{0} ", sum);
    }
}
/*
OutPut:
PS D:\CodewithVishu\C#.Net\Sum of Ele in Array> dotnet run
Program  For implementations  Addition of elements in Array
Eneter the Size Of Array:: 
2
Size Of Array is :: 2
1
2
Elements in Array =>             1       2
Addition of eleemnts in Array =>3 
PS D:\CodewithVishu\C#.Net\Sum of Ele in Array> 

*/