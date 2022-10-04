public static class ListExamples
{
    public static void FindLastGreatestSubsequentWordInAStringUsingList()
    {
        var puzzle = "hellothisisHarikrishnYadavGalamnopqruvsttksn";
        var result = string.Empty;
        var characterList = puzzle.ToCharArray();
        var subSequentString = new List<char>();

        foreach (char character in characterList)
        {
            if (subSequentString.Any(a => a == character))
            {
                if (result.Length <= subSequentString.Count)
                {
                    result = new string(subSequentString.ToArray());
                    Console.WriteLine("temporary result using List : " + result);
                }
                subSequentString.Clear();
            }

            subSequentString.Add(character);
        }

        if (result.Length <= subSequentString.Count)
        {
            result = new string(subSequentString.ToArray()); ;
        }
        Console.WriteLine("Using List " + result);
    }
}