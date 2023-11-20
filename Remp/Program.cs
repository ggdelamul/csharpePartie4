//Mise en forme de chaînes en les faisant précéder ou suivre d’un espace blanc
string input ="Pad this";
Console.WriteLine(input.PadLeft(12,'-'));
//ajoute autant d'espace blanc pour atteindre 12 caractère pour la chaine a gayche


//Utilisation de chaînes remplies
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";
var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);