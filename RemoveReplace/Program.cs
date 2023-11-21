///methode remove
//Supprimer des caractères dans des emplacements spécifiques d’une chaîne
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
//position de depart , nbr de caractère
Console.WriteLine(updatedData);

///methode replace
///Supprimer des caractères, où qu’ils soient dans une chaîne
///
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);