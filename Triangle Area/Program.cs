using System;
namespace program
{
    class AreaofTraingle : TwoDShape // derived class
    {
        public static void Main(String[] args)
        {
            TwoDShape two = new TwoDShape();
            Console.WriteLine("Enter the Value of Base and Height of array: ");
            double area;
            area = (two.baseOfTraingle * two.heightOfTraingle) / 2;
            Console.Write("Area of The Traingle ::: ");
            Console.WriteLine(area);
        }
    }
}
/*
Out Put

PS D:\CodewithVishu\C#.Net\Practice Pqms> dotnet run
Enter the Value of Base and Height of array: 
5
6
Area of The Traingle ::: 15
PS D:\CodewithVishu\C#.Net\Practice Pqms> 

*/