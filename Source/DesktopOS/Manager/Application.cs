using System.IO;
using ImGuiNET;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Manager;

internal sealed class Application : Game
{
    private readonly GraphicsDeviceManager _graphics;
    private ImGuiRenderer? _renderer;
    private ImFontPtr _font;

    public Application()
    {
        _graphics = new GraphicsDeviceManager(this)
        {
            PreferredBackBufferWidth = 1024,
            PreferredBackBufferHeight = 768
        };

        IsMouseVisible = true;
        Window.AllowUserResizing = true;
        Content.RootDirectory = "Content";
    }

    protected override void Initialize()
    {
        _renderer = new(this);

        var path = Path.Combine(Directory.GetCurrentDirectory(), "Content", "Macintosh Regular.ttf");
        var io = ImGui.GetIO();
        _font = io.Fonts.AddFontFromFileTTF(path, 42.0f);

        _renderer.RebuildFontAtlas();

        LightTheme.ApplyThemeTo(Theme.Current);

        base.Initialize();
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.White);

        _renderer!.BeginLayout(gameTime);
        //ImGui.PushFont(_font);
        DrawGui();
        //ImGui.PopFont();
        _renderer.EndLayout();

        base.Draw(gameTime);
    }

    private void DrawGui()
    {
        var menu = new Menu();
        menu.Draw();

        //var io = ImGui.GetIO();
        //ImGui.SetNextWindowPos(System.Numerics.Vector2.Zero);
        //ImGui.SetNextWindowSize(io.DisplaySize);

        ImGui.Begin("main");
        var draw = ImGui.GetWindowDrawList();
        draw.AddRect(new System.Numerics.Vector2(10.0f), new System.Numerics.Vector2(50.0f), 0);

        //ImGui.ShowDemoWindow();
        //ImGui.ShowStyleEditor();
        ImGui.End();
    }
}
