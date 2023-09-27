// See https://aka.ms/new-console-template for more information
using Codility_BinaryGap;

Console.WriteLine("Codility BinaryGap Exercise");
Console.WriteLine("Write a number in order to calculate its binary gaps...");

var number = int.Parse(Console.ReadLine());
var binaryNumber = Solution.GetBinaryRepresentation(number);

Console.WriteLine($"Number: { number }, Binary representation: { binaryNumber }");
Console.WriteLine($"Binary Gaps with largest length: { Solution.BinarySolution(number) }");

Console.ReadLine();