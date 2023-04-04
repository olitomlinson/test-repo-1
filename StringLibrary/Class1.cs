namespace UtilityLibraries;

public static class StringLibrary
{
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }

    public static bool NewMethod(this string? str) 
    {
        return false;
    }

    public static bool AnotherUntestedMethod(this string? str) 
    {
        return false;
    }

     public static bool AnotherUntestedMethod2(this string? str) 
    {
        return false;
    }
}