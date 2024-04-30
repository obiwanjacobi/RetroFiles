using System;
using ImGuiNET;

namespace Manager;

internal sealed class Menu
{
    public Menu()
    { }

    public void Draw()
    {
        if (ImGui.BeginMainMenuBar())
        {
            if (ImGui.BeginMenu("Desktop"))
            {
                if (ImGui.MenuItem("About..."))
                {
                    Console.WriteLine("Desktop->About...");
                }
                ImGui.EndMenu();
            }
            ImGui.EndMainMenuBar();
        }
    }
}
