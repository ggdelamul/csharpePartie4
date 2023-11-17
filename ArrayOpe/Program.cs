// string[] pallets = { "B14", "A11", "B12", "A13" };
// //methode Sort
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// //Methode Reverse
// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }



//////////////////////////////////methode Clear 
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");
// Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);//la valeur de l'index est null
// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");//permets d'éviter le message d'erreur
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//////////////////////////////methode Resize
Console.WriteLine("");
Array.Resize(ref pallets,6);//passage de parametre par référence
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");
Array.Resize(ref pallets, 3);//supprimera les derniers éléments saisie
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//////////////////////////////method ToCharArray
Console.WriteLine("method ToCharArray\n");

string value = "abc123";
char[] valueArray = value.ToCharArray();//ressort un tableau descaractere de la chaine 
Array.Reverse(valueArray);
// string result = new string(valueArray);//retransforme le tableau en chaine 
//////////////////////////////method Join
string result = String.Join(",", valueArray);
Console.WriteLine(result);

//////////////////////////////method Split
string items []= result.Split(',');//supprime le cractère , 
foreach (string item in items)
{
    Console.WriteLine(item);
}
