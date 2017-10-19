using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What's the word?");
        string word = Console.ReadLine().ToLower();
        Console.WriteLine(TranslateWord(word));
        Console.ReadLine();
    }
    
    public static string TranslateWord(string word)
    {
        //1 - Translate simple word

        // string firstCharacter = word.Substring(0, 1);
        // string restWord = word.Substring(1);
        // return restWord + firstCharacter + "ay";

        //2 - Translate a more complex word

        //Looking for the first vowel

        int indexOfFirstVowel = -1;

        //go through every vowel and ask if it is a art of the word

        if ((word.IndexOf('a') > -1 && word.IndexOf('a') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('a');
        }

        if ((word.IndexOf('e') > -1 && word.IndexOf('e') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('e');
        }

        if ((word.IndexOf('i') > -1 && word.IndexOf('i') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('i');
        }

        if ((word.IndexOf('o') > -1 && word.IndexOf('o') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('o');
        }

        if ((word.IndexOf('u') > -1 && word.IndexOf('u') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('u');
        }

        if ((word.IndexOf('y') > -1 && word.IndexOf('y') < indexOfFirstVowel)
            ||
            indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('y');
        }

        if (indexOfFirstVowel == 0) { return word + "yay"; }

        string RestOfWord = word.Substring(indexOfFirstVowel);
        string FirstPart = word.Substring(0, indexOfFirstVowel);

        
    }
}
