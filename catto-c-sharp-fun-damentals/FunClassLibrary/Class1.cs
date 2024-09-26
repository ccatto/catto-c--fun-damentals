namespace FunClassLibrary;

public static class Class1
{
    #region "Methods"
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }
    #endregion
}

