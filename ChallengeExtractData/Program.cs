const string input = 
"<div><h2>Widgets &trade;</h2><span>5000</span></div>";
string quantity = "";
string output = "";
// Your work here
//1 Affectez à la variable quantity la valeur en extrayant le texte entre les balises <span> et </span>
const string openSpan = "<span>";
const string closeSpan = "</span>";
int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);
Console.WriteLine(openingPosition);
int length = closingPosition-openingPosition;
openingPosition +=6;
quantity = input.Substring(openingPosition, length-6);
//2 Affectez à la variable output la valeur d’entrée, puis supprimez les balises <div> et </div>.
//3Remplacez le caractère HTML ™ (&trade;) par dans la variable ® (&reg) dans la variable output.
const string closeDiv = "</div>";
int closingPositionDiv = input.IndexOf(closeDiv);
// Console.WriteLine($"{closingPositionDiv} ICI tag fermeture div ");
// Console.WriteLine(input[46]);
output = input.Remove(0,4);
output=input.Remove(closingPositionDiv, 6);
output= input.Replace("&trade;","&reg;");
// Console.WriteLine(output);
/* ouput
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/
Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");

