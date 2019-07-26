using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ObjectData;

namespace FreshStart
{
	class FreshStart : Mod
	{
		public FreshStart()
		{
		}
	}

	public class SetAttributesPlayer : ModPlayer
	{
		public override void OnRespawn(Player player)
		{
			player.statLife = player.statLifeMax2;
			player.statMana = player.statManaMax2;
		}
	}
}