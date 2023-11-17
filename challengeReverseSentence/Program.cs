string pangram = "The quick brown fox jumps over the lazy dog";

string [] arrayPangram = pangram.Split(" ");
string [] reverseSentenceArray= new string [arrayPangram.Length];

for(int i =0; i< arrayPangram.Length; i++)
{
    char [] currentWord = arrayPangram[i].ToCharArray() ;
    Array.Reverse(currentWord);
    string reverseWord = new string(currentWord);
    reverseSentenceArray[i] = reverseWord; 
    // Console.WriteLine(reverseSentenceArray[i]);
}

string reverseSentence = String.Join(" ",reverseSentenceArray);
Console.WriteLine(reverseSentence);