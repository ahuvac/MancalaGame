﻿using System;
namespace Mancala
{
    class UserInput
    {
        public static int getInteger()
        {
            return getInteger("Please enter an integer");
        }

        public static int getInteger(String prompt)
        {
            int intRV = 0;
            String userRowInput = "";
            bool done = false;
            do
            {
                Console.Write(prompt + " ");
                userRowInput = Console.ReadLine();
                try
                {
                    if (int.TryParse(userRowInput, out intRV)) done = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(userRowInput + " is not an integer");
                }
            }
            while (!done);
            return intRV;
        }

        public static int getInteger(int min, int max)
        {
            return getInteger("please enter an integer", min, max);
        }

        public static int getInteger(String prompt, int min, int max)
        {
            int intRV = 0; String userRowInput = "";
            if (min > max) // then flip them
            {
                min += max;
                max = min - max;
                min = min - max;
            }
            bool done = false;
            do
            {
                Console.Write(prompt + " between " + min + " and " + max + " ");
                userRowInput = Console.ReadLine();
                try

                {
                    if (int.TryParse(userRowInput, out intRV))
                    {
                        if (intRV < min || intRV > max)
                        {
                            Console.WriteLine(userRowInput + " is not a valid number");
                        }
                        else
                        {
                            done = true;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine(userRowInput + " is not a number");
                }
            }
            while (!done);
            return intRV;
        }
    }
}

