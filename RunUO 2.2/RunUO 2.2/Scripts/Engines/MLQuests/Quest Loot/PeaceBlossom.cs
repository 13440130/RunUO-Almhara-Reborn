using System;
using Server;

namespace Server.Items
{
	public class PeaceBlossom : Item
	{
		[Constructable]
		public PeaceBlossom() : this( 1 )
		{
		}

		[Constructable]
		public PeaceBlossom( int amount ) : base( 22329 )
		{
                        Name = "Peace Blossom - (Quest Item)";
			Stackable = true;
			Amount = amount;

			Weight = 0.1;
			Hue = 1166;
			LootType = LootType.Blessed;
		}

		public override void OnDoubleClick( Mobile m )
		{
			m.SendMessage( "blossom that is used for various quests." );
		}

		public PeaceBlossom( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}