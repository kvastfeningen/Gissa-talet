 private static void Slumptal()
        {
            Random rand = new Random();
            int gissningar = 0;

            int num = rand.Next(1, 100);
            Console.WriteLine("Gissa ett nummer mellan 1 och 100!");

            int i = 0;

            while (gissningar != num)
            {
                try
                {
                    gissningar = Convert.ToInt32(Console.ReadLine());

                    if (gissningar > num)
                    {
                        Console.WriteLine("För högt");
                    }
                    else
                    {
                        Console.WriteLine("För lågt");
                    }
                }

                catch
                {
                    Console.WriteLine("Nummer!");
                    i--;
                }

                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Grattis, du hade " + i + " gissningar");

            Console.Write("\r\nTryck Enter för att komma till menyn");
            Console.ReadLine();
        }