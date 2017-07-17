using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;

namespace MeleeToThrowing
{
	class MeleeToThrowing : Mod
	{
		public MeleeToThrowing(){
			Properties = new ModProperties(){
				Autoload = true
			};
        }
    }
}
