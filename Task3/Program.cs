// See https://aka.ms/new-console-template for more information
byte myByte = 255;
short myShort = 32000;
int myInt = 42;
long myLong = 10000000000;
float myFloat = 3.14f;
double myDouble = 3.141592;
decimal myDecimal = 3.141592m;
char myChar = 'A';
bool myBool = true;

// Convert integer to string
string intAsString = myInt.ToString();

// Convert string "3.14" to double
double piDouble = Convert.ToDouble("3.14");

// Print all variables
Console.WriteLine("byte: " + myByte);
Console.WriteLine("short: " + myShort);
Console.WriteLine("int: " + myInt);
Console.WriteLine("long: " + myLong);
Console.WriteLine("float: " + myFloat);
Console.WriteLine("double: " + myDouble);
Console.WriteLine("decimal: " + myDecimal);
Console.WriteLine("char: " + myChar);
Console.WriteLine("bool: " + myBool);
Console.WriteLine("Integer as string: " + intAsString);
Console.WriteLine("String \"3.14\" as double: " + piDouble);
