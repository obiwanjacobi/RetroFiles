using System.Numerics;
using System.Security.Cryptography;
using ImGuiNET;

namespace Manager;

internal sealed class Theme
{
    public static Theme Current
        => new Theme();

    private Theme()
    {
        var style = ImGui.GetStyle();
        _colors = new(style.Colors);
    }

    private readonly ThemeColors _colors;
    public ThemeColors Colors => _colors;

    private readonly ThemeFont _font = new();
    public ThemeFont Font => _font;
}

internal sealed class ThemeColors
{
    private readonly RangeAccessor<Vector4> _colors;

    public ThemeColors(RangeAccessor<Vector4> colors)
        => _colors = colors;

    public Color WindowBackground
    {
        get { return GetColor(ImGuiCol.WindowBg); }
        set { SetColor(ImGuiCol.WindowBg, value); }
    }
    public Color ChildBackground
    {
        get { return GetColor(ImGuiCol.ChildBg); }
        set { SetColor(ImGuiCol.ChildBg, value); }
    }
    public Color PopupBackground
    {
        get { return GetColor(ImGuiCol.PopupBg); }
        set { SetColor(ImGuiCol.PopupBg, value); }
    }
    public Color Text
    {
        get { return GetColor(ImGuiCol.Text); }
        set { SetColor(ImGuiCol.Text, value); }
    }
    public Color TextDisabled
    {
        get { return GetColor(ImGuiCol.TextDisabled); }
        set { SetColor(ImGuiCol.TextDisabled, value); }
    }
    public Color TextSelectedBackground
    {
        get { return GetColor(ImGuiCol.TextSelectedBg); }
        set { SetColor(ImGuiCol.TextSelectedBg, value); }
    }
    public Color Border
    {
        get { return GetColor(ImGuiCol.Border); }
        set { SetColor(ImGuiCol.Border, value); }
    }
    public Color BorderShadow
    {
        get { return GetColor(ImGuiCol.BorderShadow); }
        set { SetColor(ImGuiCol.BorderShadow, value); }
    }
    public Color FrameBackground
    {
        get { return GetColor(ImGuiCol.FrameBg); }
        set { SetColor(ImGuiCol.FrameBg, value); }
    }
    public Color FrameBackgroundHovered
    {
        get { return GetColor(ImGuiCol.FrameBgHovered); }
        set { SetColor(ImGuiCol.FrameBgHovered, value); }
    }
    public Color FrameBackgroundActive
    {
        get { return GetColor(ImGuiCol.FrameBgActive); }
        set { SetColor(ImGuiCol.FrameBgActive, value); }
    }
    public Color TitleBackground
    {
        get { return GetColor(ImGuiCol.TitleBg); }
        set { SetColor(ImGuiCol.TitleBg, value); }
    }
    public Color TitleBackgroundActive
    {
        get { return GetColor(ImGuiCol.TitleBgActive); }
        set { SetColor(ImGuiCol.TitleBgActive, value); }
    }
    public Color TitleBackgroundCollapsed
    {
        get { return GetColor(ImGuiCol.TitleBgCollapsed); }
        set { SetColor(ImGuiCol.TitleBgCollapsed, value); }
    }
    public Color MenuBarBackground
    {
        get { return GetColor(ImGuiCol.MenuBarBg); }
        set { SetColor(ImGuiCol.MenuBarBg, value); }
    }
    public Color ScrollbarBackground
    {
        get { return GetColor(ImGuiCol.ScrollbarBg); }
        set { SetColor(ImGuiCol.ScrollbarBg, value); }
    }
    public Color ScrollbarGrab
    {
        get { return GetColor(ImGuiCol.ScrollbarGrab); }
        set { SetColor(ImGuiCol.ScrollbarGrab, value); }
    }
    public Color ScrollbarGrabHovered
    {
        get { return GetColor(ImGuiCol.ScrollbarGrabHovered); }
        set { SetColor(ImGuiCol.ScrollbarGrabHovered, value); }
    }
    public Color ScrollbarGrabActive
    {
        get { return GetColor(ImGuiCol.ScrollbarGrabActive); }
        set { SetColor(ImGuiCol.ScrollbarGrabActive, value); }
    }
    public Color CheckMark
    {
        get { return GetColor(ImGuiCol.CheckMark); }
        set { SetColor(ImGuiCol.CheckMark, value); }
    }
    public Color SliderGrab
    {
        get { return GetColor(ImGuiCol.SliderGrab); }
        set { SetColor(ImGuiCol.SliderGrab, value); }
    }
    public Color SliderGrabActive
    {
        get { return GetColor(ImGuiCol.SliderGrabActive); }
        set { SetColor(ImGuiCol.SliderGrabActive, value); }
    }
    public Color Button
    {
        get { return GetColor(ImGuiCol.Button); }
        set { SetColor(ImGuiCol.Button, value); }
    }
    public Color ButtonHovered
    {
        get { return GetColor(ImGuiCol.ButtonHovered); }
        set { SetColor(ImGuiCol.ButtonHovered, value); }
    }
    public Color ButtonActive
    {
        get { return GetColor(ImGuiCol.ButtonActive); }
        set { SetColor(ImGuiCol.ButtonActive, value); }
    }
    public Color Header
    {
        get { return GetColor(ImGuiCol.Header); }
        set { SetColor(ImGuiCol.Header, value); }
    }
    public Color HeaderHovered
    {
        get { return GetColor(ImGuiCol.HeaderHovered); }
        set { SetColor(ImGuiCol.HeaderHovered, value); }
    }
    public Color HeaderActive
    {
        get { return GetColor(ImGuiCol.HeaderActive); }
        set { SetColor(ImGuiCol.HeaderActive, value); }
    }
    public Color Separator
    {
        get { return GetColor(ImGuiCol.Separator); }
        set { SetColor(ImGuiCol.Separator, value); }
    }
    public Color SeparatorHovered
    {
        get { return GetColor(ImGuiCol.SeparatorHovered); }
        set { SetColor(ImGuiCol.SeparatorHovered, value); }
    }
    public Color SeparatorActive
    {
        get { return GetColor(ImGuiCol.SeparatorActive); }
        set { SetColor(ImGuiCol.SeparatorActive, value); }
    }
    public Color ResizeGrip
    {
        get { return GetColor(ImGuiCol.ResizeGrip); }
        set { SetColor(ImGuiCol.ResizeGrip, value); }
    }
    public Color ResizeGripHovered
    {
        get { return GetColor(ImGuiCol.ResizeGripHovered); }
        set { SetColor(ImGuiCol.ResizeGripHovered, value); }
    }
    public Color ResizeGripActive
    {
        get { return GetColor(ImGuiCol.ResizeGripActive); }
        set { SetColor(ImGuiCol.ResizeGripActive, value); }
    }
    public Color Tab
    {
        get { return GetColor(ImGuiCol.Tab); }
        set { SetColor(ImGuiCol.Tab, value); }
    }
    public Color TabHovered
    {
        get { return GetColor(ImGuiCol.TabHovered); }
        set { SetColor(ImGuiCol.TabHovered, value); }
    }
    public Color TabActive
    {
        get { return GetColor(ImGuiCol.TabActive); }
        set { SetColor(ImGuiCol.TabActive, value); }
    }
    public Color TabUnfocused
    {
        get { return GetColor(ImGuiCol.TabUnfocused); }
        set { SetColor(ImGuiCol.TabUnfocused, value); }
    }
    public Color TabUnfocusedActive
    {
        get { return GetColor(ImGuiCol.TabUnfocusedActive); }
        set { SetColor(ImGuiCol.TabUnfocusedActive, value); }
    }
    public Color DockingPreview
    {
        get { return GetColor(ImGuiCol.DockingPreview); }
        set { SetColor(ImGuiCol.DockingPreview, value); }
    }
    public Color DockingEmptyBackground
    {
        get { return GetColor(ImGuiCol.DockingEmptyBg); }
        set { SetColor(ImGuiCol.DockingEmptyBg, value); }
    }
    public Color PlotLines
    {
        get { return GetColor(ImGuiCol.PlotLines); }
        set { SetColor(ImGuiCol.PlotLines, value); }
    }
    public Color PlotLinesHovered
    {
        get { return GetColor(ImGuiCol.PlotLinesHovered); }
        set { SetColor(ImGuiCol.PlotLinesHovered, value); }
    }
    public Color PlotHistogram
    {
        get { return GetColor(ImGuiCol.PlotHistogram); }
        set { SetColor(ImGuiCol.PlotHistogram, value); }
    }
    public Color PlotHistogramHovered
    {
        get { return GetColor(ImGuiCol.PlotHistogramHovered); }
        set { SetColor(ImGuiCol.PlotHistogramHovered, value); }
    }
    public Color TableHeaderBackground
    {
        get { return GetColor(ImGuiCol.TableHeaderBg); }
        set { SetColor(ImGuiCol.TableHeaderBg, value); }
    }
    public Color TableBorderStrong
    {
        get { return GetColor(ImGuiCol.TableBorderStrong); }
        set { SetColor(ImGuiCol.TableBorderStrong, value); }
    }
    public Color TableBorderLight
    {
        get { return GetColor(ImGuiCol.TableBorderLight); }
        set { SetColor(ImGuiCol.TableBorderLight, value); }
    }
    public Color TableRowBackground
    {
        get { return GetColor(ImGuiCol.TableRowBg); }
        set { SetColor(ImGuiCol.TableRowBg, value); }
    }
    public Color TableRowBackgroundAlt
    {
        get { return GetColor(ImGuiCol.TableRowBgAlt); }
        set { SetColor(ImGuiCol.TableRowBgAlt, value); }
    }
    public Color DragDropTarget
    {
        get { return GetColor(ImGuiCol.DragDropTarget); }
        set { SetColor(ImGuiCol.DragDropTarget, value); }
    }
    public Color NavHighlight
    {
        get { return GetColor(ImGuiCol.NavHighlight); }
        set { SetColor(ImGuiCol.NavHighlight, value); }
    }
    public Color NavWindowingHighlight
    {
        get { return GetColor(ImGuiCol.NavWindowingHighlight); }
        set { SetColor(ImGuiCol.NavWindowingHighlight, value); }
    }
    public Color NavWindowingDimBackground
    {
        get { return GetColor(ImGuiCol.NavWindowingDimBg); }
        set { SetColor(ImGuiCol.NavWindowingDimBg, value); }
    }
    public Color ModalWindowDimBackground
    {
        get { return GetColor(ImGuiCol.ModalWindowDimBg); }
        set { SetColor(ImGuiCol.ModalWindowDimBg, value); }
    }

    private void SetColor(ImGuiCol color, Color value)
        => _colors[(int)color] = value.ToVector();
    private Color GetColor(ImGuiCol color)
        => new Color(_colors[(int)color]);
}

internal sealed class ThemeFont
{
    public int Size { get; set; }
}

internal interface IThemeBuilder
{
    static abstract void ApplyThemeValues(Theme theme);
}

internal struct Color
{
    public Color(Vector4 color)
    {
        R = (byte)(color.X * 255f);
        G = (byte)(color.Y * 255f);
        B = (byte)(color.Z * 255f);
        A = (byte)(color.W * 255f);
    }
    public Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
        A = 255;
    }

    public byte R;
    public byte G;
    public byte B;
    public byte A;

    public Vector4 ToVector()
        => new(R / 255f, G / 255f, B / 255f, A / 255f);
}