using System;
using Server;
using Server.Spells.Eighth;
using Server.Targeting;


namespace Server.Items
{
	public class ResurrectionWand : BaseWand
	{
		[Constructable]
		public ResurrectionWand() : base( WandEffect.Resurrection, 5, 50 )
		{
                Name = "Resurrection Wand";
		}

		public ResurrectionWand( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void OnWandUse( Mobile from )
		{
			Cast( new ResurrectionSpell( from, this ) );
		}
	}
}