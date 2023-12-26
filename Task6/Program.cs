List<bool> values = new List<bool>{ true, true, true };

bool alltrue = values.Exists(val => val == true);
Console.WriteLine("Are all the values in the list true? " + alltrue);