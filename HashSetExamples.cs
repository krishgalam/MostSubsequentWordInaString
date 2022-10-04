public static class HashSetExamples
{
    public static void FindLastGreatestSubsequentWordInAStringUsingHashSet()
    {
        var puzzle = "hellothisisHarikrishnYadavGalamnopqruvsttksn";
        var hashSet = new HashSet<char>();
        var result = string.Empty;
        var characterList = puzzle.ToCharArray();
        foreach (char character in characterList)
        {
            if (hashSet.Any(a => a == character))
            {
                if (result.Length < hashSet.Count)
                {
                    result = new String(hashSet.ToArray());
                    Console.WriteLine("temporary result using Hashset : " + result);
                }
                hashSet.Clear();
            }
            hashSet.Add(character);
        }

        if (result.Length < hashSet.Count)
        {
            result = new String(hashSet.ToArray());
        }

        Console.WriteLine("Final result using Hashset : " + result);
    }
}