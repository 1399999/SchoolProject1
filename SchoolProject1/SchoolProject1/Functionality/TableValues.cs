namespace SchoolProject1.Functionality;
public class TableValues1
{
    public string Column1 { get; set; } = string.Empty;
}

public class TableValues2
{
    public string Column1 { get; set; } = string.Empty;
    public string Column2 { get; set; } = string.Empty;
}

public class TableValues3
{
    public string Column1 { get; set; } = string.Empty;
    public string Column2 { get; set; } = string.Empty;
    public string Column3 { get; set; } = string.Empty;
}

public class TableValues4
{
    public string Column1 { get; set; } = string.Empty;
    public string Column2 { get; set; } = string.Empty;
    public string Column3 { get; set; } = string.Empty;
    public string Column4 { get; set; } = string.Empty;
}

public class TableValues5
{
    public string Column1 { get; set; } = string.Empty;
    public string Column2 { get; set; } = string.Empty;
    public string Column3 { get; set; } = string.Empty;
    public string Column4 { get; set; } = string.Empty;
    public string Column5 { get; set; } = string.Empty;
}

public static class TableValues
{
    public static List<TableValues1> Table1 { get; set; } = new();
    public static List<TableValues2> Table2 { get; set; } = new();
    public static List<TableValues3> Table3 { get; set; } = new();
    public static List<TableValues4> Table4 { get; set; } = new();
    public static List<TableValues5> Table5 { get; set; } = new();

    public static void Update(this List<object> list)
    {
        var type = list.GetType();

        if (type == typeof(TableValues1))
        {
            for (int i = 0; i < list.Count; i++)
            {
                TableValues1 tableValues = (TableValues1)list[i];

                Table1[i].Column1 = tableValues.Column1;
                Table2[i].Column1 = tableValues.Column1;
                Table3[i].Column1 = tableValues.Column1;
                Table4[i].Column1 = tableValues.Column1;
                Table5[i].Column1 = tableValues.Column1;
            }
        }

        else if (type == typeof(TableValues2))
        {
            for (int i = 0; i < list.Count; i++)
            {
                TableValues2 tableValues = (TableValues2)list[i];

                Table1[i].Column1 = tableValues.Column1;
                Table2[i].Column1 = tableValues.Column1;
                Table3[i].Column1 = tableValues.Column1;
                Table4[i].Column1 = tableValues.Column1;
                Table5[i].Column1 = tableValues.Column1;

                Table2[i].Column2 = tableValues.Column2;
                Table3[i].Column2 = tableValues.Column2;
                Table4[i].Column2 = tableValues.Column2;
                Table5[i].Column2 = tableValues.Column2;
            }
        }

        else if (type == typeof(TableValues3))
        {
            for (int i = 0; i < list.Count; i++)
            {
                TableValues3 tableValues = (TableValues3)list[i];

                Table1[i].Column1 = tableValues.Column1;
                Table2[i].Column1 = tableValues.Column1;
                Table3[i].Column1 = tableValues.Column1;
                Table4[i].Column1 = tableValues.Column1;
                Table5[i].Column1 = tableValues.Column1;

                Table2[i].Column2 = tableValues.Column2;
                Table3[i].Column2 = tableValues.Column2;
                Table4[i].Column2 = tableValues.Column2;
                Table5[i].Column2 = tableValues.Column2;

                Table3[i].Column3 = tableValues.Column3;
                Table4[i].Column3 = tableValues.Column3;
                Table5[i].Column3 = tableValues.Column3;
            }
        }

        else if (type == typeof(TableValues4))
        {
            for (int i = 0; i < list.Count; i++)
            {
                TableValues4 tableValues = (TableValues4)list[i];

                Table1[i].Column1 = tableValues.Column1;
                Table2[i].Column1 = tableValues.Column1;
                Table3[i].Column1 = tableValues.Column1;
                Table4[i].Column1 = tableValues.Column1;
                Table5[i].Column1 = tableValues.Column1;

                Table2[i].Column2 = tableValues.Column2;
                Table3[i].Column2 = tableValues.Column2;
                Table4[i].Column2 = tableValues.Column2;
                Table5[i].Column2 = tableValues.Column2;

                Table3[i].Column3 = tableValues.Column3;
                Table4[i].Column3 = tableValues.Column3;
                Table5[i].Column3 = tableValues.Column3;

                Table4[i].Column4 = tableValues.Column4;
                Table5[i].Column4 = tableValues.Column4;
            }
        }

        else if (type == typeof(TableValues5))
        {
            for (int i = 0; i < list.Count; i++)
            {
                TableValues5 tableValues = (TableValues5)list[i];

                Table1[i].Column1 = tableValues.Column1;
                Table2[i].Column1 = tableValues.Column1;
                Table3[i].Column1 = tableValues.Column1;
                Table4[i].Column1 = tableValues.Column1;
                Table5[i].Column1 = tableValues.Column1;

                Table2[i].Column2 = tableValues.Column2;
                Table3[i].Column2 = tableValues.Column2;
                Table4[i].Column2 = tableValues.Column2;
                Table5[i].Column2 = tableValues.Column2;

                Table3[i].Column3 = tableValues.Column3;
                Table4[i].Column3 = tableValues.Column3;
                Table5[i].Column3 = tableValues.Column3;

                Table4[i].Column4 = tableValues.Column4;
                Table5[i].Column4 = tableValues.Column4;

                Table5[i].Column5 = tableValues.Column5;
            }
        }
    }
}
