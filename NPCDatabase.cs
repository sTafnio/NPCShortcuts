using System.Collections.Generic;

namespace NPCShortcuts;

public static class NPCDatabase
{
    public static Dictionary<string, NPC> NPCDictionary = new()
    {
        // Act 1
        {
            "Metadata/NPC/Act1/Nessa", new NPC
            {
                Name = "Nessa",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act1/Tarkleigh", new NPC
            {
                Name = "Tarkleigh",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        // Act 2
        {
            "Metadata/NPC/Act2/Greust", new NPC
            {
                Name = "Greust",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act2/HelenaTown", new NPC
            {
                Name = "Helena",
                Ctrl = "Hideout",
            }
        },
        {
            "Metadata/NPC/Act2/Yeena", new NPC
            {
                Name = "Yeena",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/League/Bestiary/Einhar", new NPC
            {
                Name = "Einhar, Beastmaster",
                Ctrl = "Bestiary",
            }
        },
        // Act3
                {
            "Metadata/NPC/Act3/ClarissaTown", new NPC
            {
                Name = "Clarissa",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act3/Hargan", new NPC
            {
                Name = "Hargan",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        // Act4
        {
            "Metadata/NPC/Act4/Kira", new NPC
            {
                Name = "Kira",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act4/PetarusVanja", new NPC
            {
                Name = "Petarus and Vanja",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act4/Tasuni", new NPC
            {
                Name = "Tasuni",
                Ctrl = "Cards",
            }
        },
        {
            "Metadata/NPC/League/Delve/DelveMiner", new NPC
            {
                Name = "Niko, Master of the Depths",
                Ctrl = "Delve Chart",
            }
        },
        // Act 5
        {
            "Metadata/NPC/Act5/Lani", new NPC
            {
                Name = "Lani",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act5/BannonTown", new NPC
            {
                Name = "Bannon",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        // Act 6
        {
            "Metadata/NPC/Act6/Lilly", new NPC
            {
                Name = "Lilly Roth",
                Ctrl = "Sell",
                Alt = "Gems",
            }
        },
        {
            "Metadata/NPC/Act6/Bestel", new NPC
            {
                Name = "Bestel",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act6/Tarkleigh", new NPC
            {
                Name = "Tarkleigh",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
                {
            "Metadata/NPC/League/Expedition/Saga", new NPC
            {
                Name = "Dannig, Warrior Skald",
                Ctrl = "Exchange",
                CtrlAlt = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Expedition/Dealer", new NPC
            {
                Name = "Rog, the Dealer",
                Ctrl = "Deal",
                Alt = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Expedition/Gambler", new NPC
            {
                Name = "Gwennen, the Gambler",
                Ctrl = "Gamble",
                Alt = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Expedition/Haggler", new NPC
            {
                Name = "Tujen, the Haggler",
                Ctrl = "Haggle",
                Alt = "Sell",
            }
        },
        // Act 7
        {
            "Metadata/NPC/League/Incursion/TreasureHunter", new NPC
            {
                Name = "Alva, Master Explorer",
                Ctrl = "Temple",
            }
        },
        {
            "Metadata/NPC/Act7/YeenaTown", new NPC
            {
                Name = "Yeena",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act7/Helena", new NPC
            {
                Name = "Helena",
                Ctrl = "Hideout",
                CtrlAlt = "Sell",
            }
        },
        // Act 8
        {
            "Metadata/NPC/Act8/ClarissaTown", new NPC
            {
                Name = "Clarissa",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act8/Hargan", new NPC
            {
                Name = "Hargan",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        // Act 9
        {
            "Metadata/NPC/Act9/Tasuni", new NPC
            {
                Name = "Tasuni",
                Ctrl = "Cards",
            }
        },
        {
            "Metadata/NPC/League/Betrayal/BetrayalNinjaCop", new NPC
            {
                Name = "Jun, Veiled Master",
                Ctrl = "Unveil",
                Alt = "Syndicate",
                CtrlAlt = "Sell",
            }
        },
        {
            "Metadata/NPC/Act9/PetarusVanja", new NPC
            {
                Name = "Petarus and Vanja",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act9/Irasha", new NPC
            {
                Name = "Irasha",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        // Act 10
        {
            "Metadata/NPC/Act10/Lani", new NPC
            {
                Name = "Lani",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act10/Weylam", new NPC
            {
                Name = "Weylam Roth",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Act10/Lilly", new NPC
            {
                Name = "Lilly Roth",
                Ctrl = "Sell",
                Alt = "Gems",
            }
        },
        // Epilogue
        {
            "Metadata/NPC/League/Blight/BlightBuilder", new NPC
            {
                Name = "Sister Cassia",
                Ctrl = "Annoint",
            }
        },
        {
            "Metadata/NPC/Epilogue/Weylam", new NPC
            {
                Name = "Weylam Roth",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Epilogue/Lani", new NPC
            {
                Name = "Lani",
                Ctrl = "Sell",
                Alt = "Purchase",
            }
        },
        {
            "Metadata/NPC/Epilogue/Helena", new NPC
            {
                Name = "Helena",
                Ctrl = "Hideout",
            }
        },
        {
            "Metadata/NPC/Epilogue/Kirac", new NPC
            {
                Name = "Commander Kirac",
                Ctrl = "Purchase",
                Alt = "Sell",
            }
        },
        // League mechanic areas
        {
            "Metadata/NPC/League/Sanctum/SanctumNPCAirlock", new NPC
            {
                Name = "Divinia",
                Ctrl = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Bestiary/EinharMenagerie", new NPC
            {
                Name = "Einhar, Beastmaster",
                Ctrl = "Bestiary",
                Alt = "Purchase",
                CtrlAlt = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Delve/DelveMinerHub", new NPC
            {
                Name = "Niko, Master of the Depths",
                Ctrl = "Delve Chart",
                Alt = "Purchase",
            }
        },
        // Hideout
        {
            "Metadata/NPC/League/Expedition/DealerHideout", new NPC
            {
                Name = "Rog, the Dealer",
                Ctrl = "Deal",
                Alt = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Expedition/SagaHideout", new NPC
            {
                Name = "Dannig, Warrior Skald",
                Ctrl = "Logbook",
                CtrlAlt = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Expedition/GamblerHideout", new NPC
            {
                Name = "Gwennen, the Gambler",
                Ctrl = "Gamble",
                Alt = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Expedition/HagglerHideout", new NPC
            {
                Name = "Tujen, the Haggler",
                Ctrl = "Haggle",
                Alt = "Sell",
            }
        },
        {
            "Metadata/NPC/Epilogue/LillyHideout", new NPC
            {
                Name = "Lilly Roth",
                Ctrl = "Sell",
                Alt = "Gems",
                CtrlAlt = "Cards",
            }
        },
        {
            "Metadata/NPC/Epilogue/KiracHideout", new NPC
            {
                Name = "Commander Kirac",
                Ctrl = "Purchase",
                Alt = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Betrayal/BetrayalNinjaCopHideout", new NPC
            {
                Name = "Jun, Veiled Master",
                Ctrl = "Unveil",
                Alt = "Syndicate",
                CtrlAlt = "Sell",
            }
        },
        {
            "Metadata/NPC/League/Incursion/TreasureHunterHideout", new NPC
            {
                Name = "Alva, Master Explorer",
                Ctrl = "Temple",
            }
        },
        {
            "Metadata/NPC/League/Delve/DelveMinerHideout", new NPC
            {
                Name = "Niko, Master of the Depths",
                Ctrl = "Delve Chart",
            }
        },
        {
            "Metadata/NPC/League/Bestiary/EinharHideout", new NPC
            {
                Name = "Einhar, Beastmaster",
                Ctrl = "Bestiary",
            }
        },
        {
            "Metadata/NPC/League/Blight/BlightBuilderHideout", new NPC
            {
                Name = "Sister Cassia",
                Ctrl = "Annoint",
            }
        },
        // missing kingsmarch npcs
        // Kingsmarch
    };
}
