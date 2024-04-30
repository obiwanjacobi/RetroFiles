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
        _font = io.Fonts.AddFontFromFileTTF(path, 32.0f);

        _renderer.RebuildFontAtlas();

        LightTheme.ApplyThemeValues(Theme.Current);

        base.Initialize();
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(new Microsoft.Xna.Framework.Color(1f, 1f, 1f));

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

        ImGui.Begin("Dear ImGui Style Editor");
        ImGui.ShowStyleEditor();
        ImGui.End();
    }
}
