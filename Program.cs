
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Find Last greatest Subsequent Word in a given string
       // FindLastGreatestSubsequentWordInAString();

        FindLastGreatestSubsequentWordInAStringUsingHashSet();
    }

    public static void FindLastGreatestSubsequentWordInAString()
    {
        var puzzle = "hellothisisHarikrishnYadavGalamnopqruvst";
        var result = string.Empty;
        var characterList = puzzle.ToCharArray();
        var intermediateResult = string.Empty;
        var duplicateCheckList = new List<char>();

        foreach (char character in characterList)
        {
            if (duplicateCheckList.Any(a => a == character))
            {
                if (result.Length <= intermediateResult.Length)
                {
                    result = intermediateResult;
                }

                intermediateResult = string.Empty;
                duplicateCheckList.Clear();
            }

            intermediateResult += character;
            duplicateCheckList.Add(character);
        }

        if (result.Length <= intermediateResult.Length)
        {
            result = intermediateResult;
        }
        Console.WriteLine(result);
    }

    public static void FindLastGreatestSubsequentWordInAStringUsingHashSet()
    {
        var puzzle = "hellothisisHarikrishnYadavGalamnopqruvst";
        var hashSet = new HashSet<char>();
        var characterList = puzzle.ToCharArray();
        var duplicateCheckList = new List<char>();
        var result = string.Empty;
        foreach (char character in characterList)
        {
            if(hashSet.Any(a => a == character))
            {
                result = hashSet.ToString();
                hashSet.Clear();
            }
            hashSet.Add(character);
        }
        Console.WriteLine(result);
    }
}