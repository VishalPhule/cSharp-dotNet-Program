using System;

namespace program
{

    public class MenuDriven
    {

        public static void Main()
        {

            int n, i, j, opt, sum;

            int[,] arr1 = new int[5, 5];
            int[,] brr1 = new int[5, 5];
            int[,] crr1 = new int[5, 5];

            Console.Write("Enter the Size of Square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert elements into first matrix::");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Element - [{0},{1}] :: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // second atrix
            Console.WriteLine("Enter  the elemnt of Second matrix ::");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Element - [{0},{1}] :: ", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Elemnt in first matrix:::");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }

            Console.WriteLine("\nElements in secons matrix ::");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", brr1[i, j]);
                }
            }

            Console.Write("\n1.Addition \n 2.Substraction\n 3.Multiplication\n 4.Transpose\n  5.Inverse\n");
            Console.WriteLine("\nSelect Your Option::: ");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {

                case 1:

                    /* calculate the sum of the matrix */
                    Console.WriteLine("Addition of two Matrixs is :: ");
                    for (i = 0; i < n; i++)
                        for (j = 0; j < n; j++)
                            crr1[i, j] = arr1[i, j] + brr1[i, j];
                    Console.WriteLine("Addition is ::");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("\n");
                            for (j = 0; j < n; j++)
                            {
                                Console.Write("{0}\t", crr1[i, j]);
                            }
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Substraction of two Matrixs is :: ");
                    for (i = 0; i < n; i++)
                        for (j = 0; j < n; j++)
                            crr1[i, j] = arr1[i, j] - brr1[i, j];
                    Console.WriteLine("Substractin  of two Matrixs is :: ");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("\n");
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0}\t", crr1[i, j]);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Multiplication of two Matrixs is :: ");
                    int sum = 0;
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("\n");
                        for (j = 0; j < n; j++)
                        { 
                            //for(int k=0;k<n;k++){
                                sum=sum+arr1[i,j]*brr1[i,j];
                                crr1[i,j]=sum;
                            //}
                           
                        }

                        for(int i = 0; i < n; i++){
                            
                        }
                    }
                    break;
            }

        }
    }
}