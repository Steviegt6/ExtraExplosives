﻿using ExtraExplosives.Projectiles;
using Terraria.ModLoader;

namespace ExtraExplosives.Items.Explosives
{
	public class BulletBoomItemIchor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BulletBoom [c/AC90FF:(Ichor Bullet)]");
			Tooltip.SetDefault("Who said a gun is the only thing that can shoot a bullet? \n" +
				"Blows up upon touching a block.");
		}

		public override string Texture => "ExtraExplosives/Items/Explosives/BulletBoomItem";

		public override void SetDefaults()
		{
			item.CloneDefaults(ModContent.ItemType<BulletBoomItem>());
			item.damage = 55;	 //The damage stat for the Weapon.
			item.shoot = ModContent.ProjectileType<BulletBoomProjectileIchor>();
		}
	}
}