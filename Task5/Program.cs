List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
Console.WriteLine("The filtered numbers are:");

 List<int> item = numbers.FindAll(even => even % 2 == 0);

foreach(int evenNumbers in item)
{
 Console.WriteLine(evenNumbers);
}