using System;

namespace SwitchStatement
{
    class Program
    {
        //Page 67 - 68
        static void Main(string[] args)
        {
            ShowCard(11);
            ShowCard(12);
            ShowCard(13);
            ShowCard(-1);
            ShowCard(25);
            MultipleCases(13);
            MultipleCases(12);
            MultipleCases(7);
            TellMeTheType(3);
            TellMeTheType("Hello world");
            TellMeTheType(5.555);
        }
        static void ShowCard(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1: // Joker is -1
                    goto case 12; // In this game joker counts as queen
                default: // Executes for any other cardNumber
                    Console.WriteLine(cardNumber);
                    break;
            }
        }
        /*When more than one value should execute the same code, you can list the common
        cases sequentially*/
        static void MultipleCases(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                case 12:
                case 11:
                    Console.WriteLine("Face card");
                    break;
                default:
                    Console.WriteLine("Plain card");
                    break;
            }
        }
        //We can also switch on types
        static void TellMeTheType(object x) // object allows any type.
        {
            switch (x)
            {
                case int i:
                    Console.WriteLine("It's an int!");
                    Console.WriteLine($"The square of {i} is {i * i}");
                    break;
                case string s:
                    Console.WriteLine("It's a string");
                    Console.WriteLine($"The length of {s} is {s.Length}");
                    break;
                default:
                    Console.WriteLine("I don't know what x is");
                    break;
            }
        }
    }
}