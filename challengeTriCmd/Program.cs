string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";


string [] arrayOrderStream = orderStream.Split(",");
Array.Sort(arrayOrderStream);
for(int i = 0; i<arrayOrderStream.Length;i++)
{
    //CORRECTION / il est possible d'utiliser Length sur une chaine directement => boucle foreach
    // Console.WriteLine(arrayOrderStream[i]);
    char [] currentOrderStream = arrayOrderStream[i].ToCharArray();
    if(currentOrderStream.Length == 4)
    {
        Console.WriteLine(arrayOrderStream[i]);
    }
    else 
    {
        Console.WriteLine($"{arrayOrderStream[i]}\tError");
    }
}