namespace SchoolProject1.Functionality;

public static class StandardModel
{
    public static bool IsSettings { get; set; }
    public static TableValues TableValues { get; set; } = new();
    public static int ColumnCount { get; set; } = 3;
}
