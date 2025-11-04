// See https://aka.ms/new-console-template for more information
int[] favoriteNumbers = { 7, 3, 42, 15, 9 };
Console.WriteLine("Original array:");
Console.WriteLine(favoriteNumbers[0]);
Console.WriteLine(favoriteNumbers[1]);
Console.WriteLine(favoriteNumbers[2]);
Console.WriteLine(favoriteNumbers[3]);
Console.WriteLine(favoriteNumbers[4]);

// 2. Sort the array in ascending order
Array.Sort(favoriteNumbers);
Console.WriteLine("\nArray after sorting in ascending order:");
Console.WriteLine(favoriteNumbers[0]);
Console.WriteLine(favoriteNumbers[1]);
Console.WriteLine(favoriteNumbers[2]);
Console.WriteLine(favoriteNumbers[3]);
Console.WriteLine(favoriteNumbers[4]);

// 3. Reverse the sorted array
Array.Reverse(favoriteNumbers);
Console.WriteLine("\nArray after reversing (descending order):");
Console.WriteLine(favoriteNumbers[0]);
Console.WriteLine(favoriteNumbers[1]);
Console.WriteLine(favoriteNumbers[2]);
Console.WriteLine(favoriteNumbers[3]);
Console.WriteLine(favoriteNumbers[4]);

// 4. Find the position of a specific number (42)
int position = Array.IndexOf(favoriteNumbers, 42);
Console.WriteLine("\nThe position of 42 in the array is: " + position);
