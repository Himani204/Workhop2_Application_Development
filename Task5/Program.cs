// See https://aka.ms/new-console-template for more information
DateTime birthDate = new DateTime(2005, 7, 7);

// 2. Create a variable for the current date and time
DateTime currentDate = DateTime.Now;

// 3. Calculate age in years
TimeSpan ageSpan = currentDate - birthDate;
int ageInYears = (int)(ageSpan.Days / 365.25);

// 4. Print birthdate, current date, and age
Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
Console.WriteLine("Current Date: " + currentDate.ToShortDateString());
Console.WriteLine("Age in years: " + ageInYears);

// 5. Add 10 days to birthdate and print
DateTime birthDatePlus10 = birthDate.AddDays(10);
Console.WriteLine("Birthdate plus 10 days: " + birthDatePlus10.ToShortDateString());