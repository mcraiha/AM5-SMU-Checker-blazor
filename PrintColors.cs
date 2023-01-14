
public enum PrintColor : byte
{
    Black = 0,
    DarkBlue,
    DarkGreen,
    DarkCyan,
    DarkRed,
    DarkMagenta,
    DarkYellow,
    Gray,
    DarkGray,
    Blue,
    Green,
    Cyan,
    Red,
    Magenta,
    Yellow,
    White
}

public static class PrintColors
{
    public static readonly Dictionary<PrintColor, string> Colors = new Dictionary<PrintColor, string>()
    {
        { PrintColor.Black, "#000000" },
        { PrintColor.DarkBlue, "#0037DA" },
        { PrintColor.DarkGreen, "#008000" },
        { PrintColor.DarkCyan, "#008080" },
        { PrintColor.DarkRed, "#800000" },
        { PrintColor.DarkMagenta, "#800080" },
        { PrintColor.DarkYellow, "#808000" },
        { PrintColor.Gray, "#C0C0C0" },
        { PrintColor.DarkGray, "#808080" },
        { PrintColor.Blue, "#0000FF" },
        { PrintColor.Green, "#00FF00" },
        { PrintColor.Cyan, "#00FFFF" },
        { PrintColor.Red, "#FF0000" },
        { PrintColor.Magenta, "#FF00FF" },
        { PrintColor.Yellow, "#FFFF00" },
        { PrintColor.White, "#FFFFFF" },
    };
}