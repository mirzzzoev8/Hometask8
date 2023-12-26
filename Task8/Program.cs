List<string> numbers = new List<string>{ "Yusufjon", "Davron" };
 var number = numbers.FindAll(number => number.Length == 6);
 foreach (var item in number)
 {
    System.Console.WriteLine(item);
 }

  
    

