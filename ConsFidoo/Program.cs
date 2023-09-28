using System;
//task 1
//Console.WriteLine("enter a number:");
//int number = int.Parse(Console.ReadLine());
//if (number <= 0)
//{
//    Console.WriteLine("A positive integer is required.");
//}
//else
//{
//    bool Power_of_two = true;
//    while (number > 1)
//    {
//        if (number % 2 != 0)
//        {
//            Power_of_two = false;
//            break;
//        }
//        number /= 2;
//    }
//    if (Power_of_two)
//    {
//        Console.WriteLine("The number is a power of 2.");
//    }
//    else
//    {
//        Console.WriteLine("The number is not a power of 2.");
//    }
//}

//task 2
//Console.WriteLine("Enter number:");
//int number = int.Parse(Console.ReadLine());
//int divisor_count = 0;
//for (int i = 2; i <= number / 2; i++)
//{
//    if (number % i == 0)
//    {
//        divisor_count++;
//    }
//}

//if (divisor_count != 0)
//{
//    Console.WriteLine("This number is composite number.");
//}
//else if (number == 1)
//{
//    Console.WriteLine("This number is neither composite nor prime");
//}
//else
//{
//    Console.WriteLine("This number is prime number.");
//}