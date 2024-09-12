using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace NPCShortcuts;

public class NPCShortcutsSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

}