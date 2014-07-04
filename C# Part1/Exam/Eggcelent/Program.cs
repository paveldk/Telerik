using System;

class Program
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        
        int Inc = height-2;

        string star = "";
        string rightdots = "";
        string leftdots = "";
        string centraldots = "";


        for (int i = 0; i < height - 1; i++)
        {
            Console.Write('.');

            if (i==0)
            {
                star = new String('*', height - 1);
                rightdots = new String('.', height);
                leftdots = new String('.', height);

                Console.Write("{0}{1}{2}", leftdots, star, rightdots);             
            }
            else
            {
                if (Inc>0)
                {
                    star = new String('*', 1);
                    rightdots = new String('.', Inc);
                    leftdots = new String('.', Inc);
                    centraldots = new String('.', 3 * height -3 - 2 * Inc);


                    Console.Write("{0}{1}{2}{1}{3}", leftdots, star, centraldots, rightdots);

                    Inc -= 2;                    
                }
                else
                {
                    star = new String('*', 1);
                    centraldots = new String('.', 3 * height -3);


                    Console.Write("{0}{1}{0}", star, centraldots);

                    Inc -= 2; 
                }

            }

            Console.WriteLine('.');
        }

        Console.Write(".*");
        for (int i = 0; i < 3 * height -3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("@");
            }
            else
            {
                Console.Write(".");
            }       
        }
        Console.WriteLine("*.");

        Console.Write(".*");
        for (int i = 0; i < 3 * height - 3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write("@");
            }
        }
        Console.WriteLine("*.");

        Inc = height;

        for (int i = 0; i < height-2; i++)
        {
            Inc -= 2;        
        }


        for (int i = height - 2; i >=0 ; i--)
        {
            Console.Write('.');

            if (i == 0)
            {
                star = new String('*', height - 1);
                rightdots = new String('.', height);
                leftdots = new String('.', height);

                Console.Write("{0}{1}{2}", leftdots, star, rightdots);
            }
            else
            {
                if (Inc > 0)
                {
                    star = new String('*', 1);
                    rightdots = new String('.', Inc);
                    leftdots = new String('.', Inc);
                    centraldots = new String('.', 3 * height - 3 - 2 * Inc);


                    Console.Write("{0}{1}{2}{1}{3}", leftdots, star, centraldots, rightdots);                 
                }
                else
                {
                    star = new String('*', 1);
                    centraldots = new String('.', 3 * height - 3);


                    Console.Write("{0}{1}{0}", star, centraldots);
                }
                Inc += 2;
            }

            Console.WriteLine('.');
        }

    }
}

