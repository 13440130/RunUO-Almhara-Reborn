using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server.Items
{
	[FlipableAttribute( 0x2B6D, 0x3164 )]
	public class FemaleWoodlandChest : BaseArmor, IDyable
	{
		public override int BasePhysicalResistance{ get{ return 17; } }

		public override int InitMinHits{ get{ return 50; } }
		public override int InitMaxHits{ get{ return 65; } }

		public override int AosStrReq{ get{ return 80; } }

		public override bool AllowMaleWearer{ get{ return false; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }

		[Constructable]
		public FemaleWoodlandChest() : base( 0x2B6D )
		{
                        Name = "Female Woodland Chest - (Lv. 48)";
			Weight = 8.0;
			Attributes.BonusHits = 65;
		}

		public override bool CanEquip( Mobile from )
		{
			PlayerMobile pm = from as PlayerMobile;

                        if ( pm.Level >= 48 )
			{
				return true;
			} 
			else
			{
				from.SendMessage( "You must reach at least level 48 in order to equip this." );
				return false;
			}
		}

		public bool Dye( Mobile from, DyeTub sender )
		{
			if ( Deleted )
				return false;

			Hue = sender.DyedHue;

			return true;
		}

		public FemaleWoodlandChest( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}
}