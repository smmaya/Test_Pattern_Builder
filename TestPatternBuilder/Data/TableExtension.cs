namespace TestPatternBuilder.Data;

public static class TableExtension
{
    public static T[]? Concatenate<T>(this T[]? mds, T[]? brs)
    {
        if (mds == null) return brs; // Correct: If the first array is null, return the second array.
        if (brs == null) return mds; // Correct: If the second array is null, return the first array.
        
        var list = new List<T>(mds.Length + brs.Length);
        list.AddRange(mds);
        list.AddRange(brs);
        return list.ToArray();
    }
}
