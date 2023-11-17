using System;
using System.Globalization;
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

//préférer l'interpolation de chaine 

///////////////////////MISE EN FORME VALEUR MONETAIRES
///

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

/*
a culture affecte le système d’écriture, le calendrier utilisé, l’ordre de tri des chaînes, ainsi que la mise en forme des dates et des nombres (comme la mise en forme de valeurs monétaires).
//pour modifier la culture
//CultureInfo currentCulture = new CultureInfo("en-US"); fr-FR fr-CA ect...
*/
CultureInfo currentCulture = new CultureInfo("en-US");
decimal measurementUs = 123456.78912m;
Console.WriteLine($"MeasurementUs: {measurementUs:N} units");
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
// CultureInfo currentCulture = new CultureInfo("fr-FR");
// decimal measurementFr = 123456.78912m;
// Console.WriteLine($"MeasurementUs: {measurementFr:N} units");
////////////////////////MISE EN FORME POURCENTAGE
///

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");


////////////////////////COMBINAISON APPROCHE DE MISE EN FORME
///