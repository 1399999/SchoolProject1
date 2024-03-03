namespace SchoolProject1.Functionality;

public static class StandardModel
{
    public static bool IsSettings { get; set; }
    public static int ColumnCount { get; set; } = 3;

    public static string EditColumnCount(int i)
    {
        ColumnCount = i;
        return string.Empty;
    }
}
