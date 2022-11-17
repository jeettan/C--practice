using System;

namespace Jake
{
    class Jakepaul
    {

       static void exercise1()
        {
            string[] arr = new string[10];

            int i = 0;

            while (true)
            {
                arr[i] = Console.ReadLine();
                if (arr[i] == "")
                {
                    break;
                }
                else
                {
                    i++;
                }
            }

            if (i == 0)
            {
                Console.WriteLine("No one likes your post");
            }

            if (i == 1)
            {
                Console.WriteLine(arr[0] + " has liked your post");
            }

            if (i == 2)
            {
                Console.WriteLine(arr[0] + " and " + arr[1] + " has liked your post");
            }

            if (i > 2)
            {
                Console.WriteLine(arr[0] + ", " + arr[1] + " and " + (i - 2) + " others liked your post");
            }
        }

        static void exercise2()
        {

            Console.WriteLine("What's your name?");

            char[] characters = Console.ReadLine().ToCharArray();

            Array.Reverse(characters);

            Console.WriteLine(characters);

        }

        static void exercise3()
        {
            int[] i = new int[5];
            int count = 0;

            int lengthcounter = 4;

            for (count = 0; count < 5; count++)
            {
                try
                {
                    i[count] = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("error");
                    count = count - 1;
                    continue;
                }

                if (count > 0)
                {
                    int lastElement = i[i.Length - lengthcounter];
                    //Console.WriteLine("Your last element is " + lastElement);

                    //Since array has some 0 in the end, have to loop through the ones that are not yet added in.
                    for (int j = 0; j < i.Length - lengthcounter; j++)
                    {
                        if (lastElement == i[j])
                        {
                            //If there is a match, adds lengthcounter, and minus the count so that it resets the loop.
                            Console.WriteLine("Error, not a unique number");
                            lengthcounter = lengthcounter + 1;
                            count = count - 1;
                        }
                    }
                    //Length counter has to go down so that the algorithm can continue
                    lengthcounter -= 1;
                }
            }

            Array.Sort(i);

            foreach (int x in i)
            {
                Console.WriteLine("Your elements are:" + x);
            }

        }

        static void exercise4()
        {
            bool truefalse = false;

            List<int> list = new List<int>();

            while (truefalse == false)
            {
                try
                {

                    Console.WriteLine("Insert a numb, or type quit");

                    var b = Console.ReadLine();

                    if (b == "Quit" || b == "quit")
                    {
                        break;

                    }
                    list.Add(Convert.ToInt32(b));

                }
                catch
                {
                    Console.WriteLine("Enter a valid number please");
                }
            }

            foreach (int i in list.Distinct())
            {
                Console.WriteLine(i);
            }

        }

        static void exercise5()
        {
            string s;
            string[] d = Array.Empty<string>();
            int[] j = Array.Empty<int>();

            while (true)
            {
                try
                {
                    s = (Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("invalid input");
                    continue;
                }
                d = s.Split(',');

                if (d.Length == 0 || d.Length < 5)
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }
                else
                {
                    break;
                }

            }

            j = Array.ConvertAll(d, int.Parse);

            Console.WriteLine(string.Join(",", j.OrderBy(x => x).Take(3)));

        }

        static void Main(string[] args)
        {
            exercise1();
        }

        
    }

}