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

        /*
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

         */

        /*
        Random rgen = new Random();
        int secret = rgen.Next(1, 11);
        bool win = false;
        while (!win)
        {
            //user input
            Console.Write("Enter Num: ");
            int ans = int.Parse(Console.ReadLine());

            //update
            if (secret == ans)
            {
                win = true;
            }

            //render
            if (win)
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
            }
            else
            {
                Console.WriteLine("Try Again...");
            }

        }
        */


        string[,] g = new string[4, 4];
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                g[x, y] = ".";
            }
        }
        Random rgen = new Random();

        //randomly place 3 lavas. BAD IDEA!!!
        int rx = rgen.Next(0, 3);
        int ry = rgen.Next(0, 3);
        g[rx, ry] = "L";
        rx = rgen.Next(0, 3);
        ry = rgen.Next(0, 3);
        g[rx, ry] = "L";
        rx = rgen.Next(0, 3);
        ry = rgen.Next(0, 3);
        g[rx, ry] = "L";

        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                Console.Write(g[x, y] + " ");
            }
            Console.WriteLine();
        }

        


        
    }
}
