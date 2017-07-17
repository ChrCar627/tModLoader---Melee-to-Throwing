using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.UI;

namespace MeleeToThrowing
{
    public class ItemChanges : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.melee && item.shoot > 0 && item.noUseGraphic && item.axe == 0 && item.pick == 0 && item.hammer == 0 && item.useStyle == 1)
            {
                item.melee = false;
                item.thrown = true;
            }
        }
    }
}
