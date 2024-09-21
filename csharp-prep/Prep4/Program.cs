using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Prep 4 Project");
        List<int> numbers = new List<int>();
        int enteredNumber = -2;

        while (enteredNumber != 0)
            {
                Console.WriteLine("Enter a number(type 0 to Quit) ");
                string userNumbers = Console.ReadLine();
                enteredNumber = int.Parse(userNumbers);

                if (enteredNumber != 0)
                    {
                        numbers.Add(enteredNumber);
                    }


              
            }

            int sum = 0;
            foreach (int number in numbers)
                {
                     sum += number;
                }
                Console.WriteLine($"The SUM of the numbers is {sum}");


            
            float average = ((float)sum)/numbers.Count;
            Console.WriteLine($"The Computed Average is {average}");


            int maximum = numbers[0];

            foreach (int number in numbers)
                {
                    if (number > maximum)
                        {
                            maximum = number;
                        }
                }
            Console.WriteLine($"The largest number is {maximum}");
    }
}