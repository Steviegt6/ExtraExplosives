using ExtraExplosives.Items;
using ExtraExplosives.Items.Explosives;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraExplosives.NPCs
{
	public class ExtraExplosivesGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity => true;

		public bool Radiated;

		public override void ResetEffects(NPC npc)
		{
			Radiated = false;
		}

		public override void UpdateLifeRegen(NPC npc, ref int damage)
		{
			if (Radiated)
			{
				if (npc.lifeRegen > 0)
				{
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 30;
				if (damage < 2)
				{
					damage = 2;
				}
			}
		}

		public override void NPCLoot(NPC npc)
		{
			if (npc.boss && Main.expertMode)
			{
				if (Main.rand.NextFloat() < 0.10210526f && npc.type != mod.NPCType("CaptainExplosive"))
				{
					Item.NewItem(Main.LocalPlayer.getRect(), ModContent.ItemType<BreakenTheBankenItem>(), 1);
				}
			}
		}

		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.Demolitionist)
			{
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<BasicExplosiveItem>());
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<SmallExplosiveItem>());
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<MediumExplosiveItem>());
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<LargeExplosiveItem>());
			}
			else if (type == NPCID.TravellingMerchant)
			{
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<SpongeItem>());
				nextSlot++;
			}
		}
	}
}