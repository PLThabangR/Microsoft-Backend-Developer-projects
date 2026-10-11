// See https://aka.ms/new-console-template for more information

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };



var evenNumbers = numbers.Where(n => n % 2 != 0).ToList();
//square the even numbers
var squaredEvenNumbers = evenNumbers.Select(n => n * n).ToList();

// Aggregate the squared even numbers
var sumOfSquaredEvenNumbers = squaredEvenNumbers.Aggregate((a, b) => a + b);

var allNumbers = numbers.All(n => n > 2);

var totalCount = numbers.Sum();

Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");
Console.WriteLine($"Squared even numbers: {string.Join(", ", squaredEvenNumbers)}");
Console.WriteLine($"Sum of squared even numbers: {sumOfSquaredEvenNumbers}");
Console.WriteLine($"All numbers greater than 2: {allNumbers}");
Console.WriteLine($"Total count of numbers: {totalCount}");

