using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ExileCore;
using ExileCore.PoEMemory;
using ExileCore.PoEMemory.Elements;
using ExileCore.PoEMemory.MemoryObjects;
using SharpDX;
using Vector2 = System.Numerics.Vector2;

namespace NPCShortcuts;

public class NPCShortcuts : BaseSettingsPlugin<NPCShortcutsSettings>
{
    public override bool Initialise()
    {
        return true;
    }

    public override void AreaChange(AreaInstance area)
    {
    }

    public override Job Tick()
    {
        return null;
    }

    public override void Render()
    {
        var labelHover = GameController.IngameState.IngameUi.ItemsOnGroundLabelElement.LabelOnHover;
        if (labelHover == null || labelHover.Type != ElementType.MiscGroundLabel) return;

        var hoverPath = GameController.IngameState.IngameUi.ItemsOnGroundLabelElement.ItemOnHoverPath;
        if (!NPCDatabase.NPCDictionary.TryGetValue(hoverPath, out var npc)) return;

        DrawShortcuts(npc, labelHover);
    }

    private void DrawShortcuts(NPC npc, Element label)
    {
        var labelRect = label.GetClientRectCache;

        var separator = "   ";
        var stringToDisplay = string.Empty;

        if (npc.Ctrl != null) stringToDisplay += "Ctrl: " + npc.Ctrl;
        if (npc.Alt != null) stringToDisplay += separator + "Alt: " + npc.Alt;
        if (npc.CtrlAlt != null) stringToDisplay += separator + "CtrlAlt: " + npc.CtrlAlt;

        var textSize = Graphics.MeasureText(stringToDisplay);


        var boxPos = new Vector2(labelRect.Center.X - textSize.X / 2, labelRect.Top - textSize.Y - 5);
        var boxSize = new Vector2(textSize.X, textSize.Y);

        Graphics.DrawBox(new RectangleF(boxPos.X, boxPos.Y, boxSize.X, boxSize.Y), Color.Black);

        var textPos = new Vector2(boxPos.X, boxPos.Y);
        Graphics.DrawText(stringToDisplay, textPos, Color.White);
    }


    public override void EntityAdded(Entity entity)
    {
    }
}