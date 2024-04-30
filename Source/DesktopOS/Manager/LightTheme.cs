namespace Manager;

internal sealed class LightTheme : IThemeBuilder
{
    private readonly static Color Black = new(0, 0, 0);
    private readonly static Color DarkGray = new(70, 70, 70);
    private readonly static Color Gray = new(153, 153, 153);
    private readonly static Color LightGray = new(240, 240, 240);
    private readonly static Color White = new(255, 255, 255);

    public static void ApplyThemeValues(Theme theme)
    {
        theme.Font.Size = 20;

        // colors
        theme.Colors.Text = Black;
        theme.Colors.TextDisabled = LightGray;
        theme.Colors.Border = Black;
        theme.Colors.BorderShadow = Black;
        theme.Colors.WindowBackground = White;
        theme.Colors.ChildBackground = White;
        theme.Colors.PopupBackground = White;
        theme.Colors.FrameBackground = White;
        theme.Colors.TitleBackground = White;
        theme.Colors.MenuBarBackground = White;
        theme.Colors.HeaderHovered = Gray;
        theme.Colors.HeaderActive = Gray;
        theme.Colors.Header = LightGray;
    }
}
