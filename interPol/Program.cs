//afficher le numero de fecture à l'aide de l'interpolation de chaine
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
//afficher un decimal au millième
Console.WriteLine($"   Shares: {productShares:N3} Product");
//affichage sous forme valeur monetaire 
Console.WriteLine($"     Sub Total: {subtotal:C}");
//afficher sous forme de pourcentage 
Console.WriteLine($"           Tax: {taxPercentage:P2}");
//format monetaire 
Console.WriteLine($"     Total Billed: {total:C}");