// See https://aka.ms/new-console-template for more information
// List of fruits
List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
fruits.Add("Orange");   // Add new fruit
fruits.Remove("Banana"); // Remove a fruit

// Print all fruits
Console.WriteLine("Fruits in the list:");
Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);
Console.WriteLine(fruits[2]);

// Dictionary of fruits
Dictionary<int, string> fruitDictionary = new Dictionary<int, string>();
fruitDictionary.Add(1, "Apple");
fruitDictionary.Add(2, "Mango");
fruitDictionary.Add(3, "Orange");
fruitDictionary.Add(4, "Pineapple"); // Add new entry

// Print dictionary
Console.WriteLine("\nFruits in dictionary:");
Console.WriteLine("ID: 1, Name: " + fruitDictionary[1]);
Console.WriteLine("ID: 2, Name: " + fruitDictionary[2]);
Console.WriteLine("ID: 3, Name: " + fruitDictionary[3]);
Console.WriteLine("ID: 4, Name: " + fruitDictionary[4]);
