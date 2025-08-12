using System;

public class Program
{
    static void Main(string[] args)
    {
        /*
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello!");
        }
        */
        Console.Write("Enter name: ");
        string n = Console.ReadLine();
        Console.WriteLine("Hi " + n + " my name is HAL!");

        int[] a = new int[7];
        a[0] = 9001;
        a[6] = 345;
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

        string[,] g = new string[4, 4];
        g[0, 2] = "Y";
        


        //Fruit f = new Fruit("Pear", 1.05);
        //Console.WriteLine(f);

        //int x = 234;
        //string s = "3kwejroiwejr welrjw erlkjwe rlkwejr ";


    }
}
