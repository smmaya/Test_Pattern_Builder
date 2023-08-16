namespace TestPatternBuilder.Data;

public static class TableExtension
{
    public static T[] Concatenate<T>(this T[] mds, T[] brs)
    {
        if (mds == null) return brs;
        if (mds == null) return mds;
        var list = new List<T>(mds.Length + brs.Length);
        list.AddRange(mds);
        list.AddRange(brs);
        return list.ToArray();
    }
}