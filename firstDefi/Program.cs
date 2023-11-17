using System;
using System.Globalization;
string[] values = { "12,3", "45", "ABC", "11", "DEF" };
string message = "";
decimal sum = 0m;

for (int i = 0; i < values.Length; i++)
{
    decimal result = 0m;
    if (decimal.TryParse(values[i], out result))
    {
        Console.WriteLine($"C'est un nombre : {values[i]}");
        sum += result; // Mettre à jour la somme avec le résultat de la conversion
    }
    else
    {
        Console.WriteLine($"Ce n'est pas un nombre : {values[i]}");
         message += value;
    }
}
//en cas de présence de décimal avec un point faire une traitement de chaine qui convertit le point en virgule sur un environnement fr
Console.WriteLine($"La somme des nombres est : {sum}");
CultureInfo currentCulture = CultureInfo.CurrentCulture;
//pour modifier la culture
//CultureInfo currentCulture = new CultureInfo("en-US");
Console.WriteLine($"Culture actuelle : {currentCulture.Name}");


