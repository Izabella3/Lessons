// See https://aka.ms/new-console-template for more information
using System;

List<int> numbers = new List<int>() { 45, 46, 78, 59, 453 };
List<int> oddNumbers = new List<int>();
List<int> evenNumbers = new List<int>();


foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
    else
    {
        oddNumbers.Add(number);
    }
}

Console.WriteLine("Odd Numbers");

foreach (var oddNumber in oddNumbers)
{ 
    Console.WriteLine(oddNumber); 
}
Console.WriteLine("Even Numbers");
foreach (var evenNumber in evenNumbers)
{
    Console.WriteLine(evenNumber);
}

Console.ReadKey();