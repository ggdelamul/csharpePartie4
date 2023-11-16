// int value = 5;
// string cinq = "5";

// // int result = value + cinq;
// string result2 = value + cinq;
// // Console.WriteLine(result);
// Console.WriteLine(result2);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");
/*
convertir une valeur depuis un type de données qui peut contenir moins d’informations vers un type de données qui peut en contenir plus. Quand vous savez que vous effectuez une conversion étendue, vous pouvez vous fier à une conversion implicite. Le compilateur gère les conversions implicites!!!!!!!!!!!!*/

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
/*La variable myDecimal contient une valeur avec une précision après la virgule. En ajoutant l’instruction de cast (int), vous indiquez au compilateur C# que vous comprenez qu’il est possible que vous perdiez cette précision, et que dans ce cas, ce n’est pas grave. Vous indiquez au compilateur que vous effectuez une conversion intentionnelle, c’est-à-dire une conversion explicite.*/

decimal myDecimal2 = 1.23456789m;
float myFloat = (float)myDecimal;
Console.WriteLine($"Decimal: {myDecimal2}");
Console.WriteLine($"Float  : {myFloat}");

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

string first2 = "5";
string second2 = "7";
int sum = int.Parse(first2) + int.Parse(second2);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

/////Les casts tronquent et les conversions arrondissent
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value5 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value5);