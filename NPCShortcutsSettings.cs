using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using Newtonsoft.Json;
using SharpDX;

namespace NPCShortcuts;

public class NPCShortcutsSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);
    public ColorNode TextColor { get; set; } = new ColorNode(Color.White);

}
