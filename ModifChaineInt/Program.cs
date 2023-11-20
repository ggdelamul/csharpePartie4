///Utiliser les méthodes d’assistance IndexOf() et Substring() de chaîne
///

//Écrire du code pour rechercher les parenthèses ouvrantes et fermantes incorporées dans une chaîne
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);//14 eme caractères 
Console.WriteLine(closingPosition);//37 eme caractères
openingPosition+=1;
//recupérer la valeur entre parenthese de la chaine
int length = closingPosition -openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));//la valeur de la position de depart est inclus dans la methode Substring retournerait la première parentheses sans l'increment précedent


/////////////////////////////////////////////////////////
Console.WriteLine("Eviter les valeurs magiques ");

string message1 = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition1 = message1.IndexOf(openSpan);
int closingPosition1 = message1.IndexOf(closeSpan);

openingPosition1 += openSpan.Length;//longueur de la chaine afin de commmencer la methode Substring a la fin du tag 
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message1.Substring(openingPosition1, length1));

///////////////////////////////////////////////////
Console.WriteLine("Récupérer la dernière occurrence d’une sous-chaîne ");
string message2 = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition2 = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition2 = message2.LastIndexOf(')');
// int length2 = closingPosition2 - openingPosition2
// Console.WriteLine(message2.Substring(openingPosition, length));

while(true)
{
    int openingPosition2 = message2.IndexOf('(');
    if(openingPosition2 == -1)//valeur retourné par IndexOf s'il ne trouve rien 
    {
        break;
    }
    openingPosition2 +=1;
    int closingPosition2 =message2.IndexOf(')');
    int length2 = closingPosition2-openingPosition2;
    Console.WriteLine(message2.Substring(openingPosition2,length2));

    message2 = message2.Substring(closingPosition2 + 1);
}

///Utiliser différents types de jeux de symboles
///
string message5 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition5 = 0;

while (true)
{
    int openingPosition5 = message5.IndexOfAny(openSymbols, closingPosition5);

    if (openingPosition5 == -1) break;

    string currentSymbol = message5.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition5 += 1;
    closingPosition5 = message5.IndexOf(matchingSymbol, openingPosition5);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length5 = closingPosition5 - openingPosition5;
    Console.WriteLine(message5.Substring(openingPosition5, length5));
}