﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraExplosives.Items.Explosives
{
	public class MegaExplosiveItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mega Explosive");
			Tooltip.SetDefault("Woah...\n" +
				"[c/AB40FF:Can destroy desert fossils]");
		}

		public override void SetDefaults()
		{
			item.damage = 0;	 //The damage stat for the Weapon.
			item.width = 20;	//sprite width
			item.height = 20;   //sprite height
			item.maxStack = 999;   //This defines the items max stack
			item.consumable = true;  //Tells the game that this should be used up once fired
			item.useStyle = 1;   //The way your item will be used, 1 is the regular sword swing for example
			item.rare = 4;	 //The color the title of your item when hovering over it ingame
			item.UseSound = SoundID.Item1; //The sound played when using this item
			item.useAnimation = 20;  //How long the item is used for.
			// item.useTime = 20;	 //How fast the item is used.
			item.value = Item.buyPrice(0, 10, 55, 00);   //How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 3 silver)
			item.noUseGraphic = true;
			item.noMelee = true;	  //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
			item.shoot = mod.ProjectileType("MegaExplosiveProjectile"); //This defines what type of projectile this item will shoot
			item.shootSpeed = 5f; //This defines the projectile speed when shot
			//item.createTile = mod.TileType("ExplosiveTile");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LargeExplosiveItem>(), 2);
			recipe.AddIngredient(ItemID.Dynamite, 2);
			recipe.AddIngredient(ItemID.Gel, 20);
			recipe.AddIngredient(ItemID.StoneBlock, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}