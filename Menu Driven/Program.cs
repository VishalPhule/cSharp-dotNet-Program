using System;

public class menuDriven
{
    public static void Main()
    {
        int num1 , num2 , opt;

        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("          Menu Driven Program Implementations    ");
        Console.WriteLine("-----------------------------------------------------");

        Console.WriteLine("Enter Num1 Value =>");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Num-2 Value =>");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Num1 and Num2 are => {0} {1}", num1, num2);

        Console.Write("\nHere are the options :\n");
        Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
        Console.Write("\nInput your choice :");

        opt = Convert.ToInt32(Console.ReadLine());

        switch (opt)
        {
            case 1:
                Console.WriteLine(" Addition Of Num1 =>{0} and Num2=>{1} are  =>{2} ", num1, num2, num1 + num2);
                break;
            case 2:
                Console.WriteLine(" Substraction Of Num1 =>{0} and Num2=>{1} are  =>{2} ", num1, num2, num1 - num2);
                break;
            case 3:
                Console.WriteLine(" Multiplication Of Num1 =>{0} and Num2=>{1} are  =>{2} ", num1, num2, num1 * num2);
                break;

            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine(" Division  Of Num1 =>{0} and Num2=>{1} are  =>{2} ", num1, num2, num1 / num2);
                }
                break;

            case 5:
                break;

            default:
                Console.Write("Input correct option\n");
                break;

        }
    }

}