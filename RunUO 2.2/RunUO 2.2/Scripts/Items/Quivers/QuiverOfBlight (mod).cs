using System;
using Server;

namespace Server.Items
{
	public class QuiverOfBlight : ElvenQuiver
	{
		public override int LabelNumber{ get{ return 1073111; } } // Quiver of Blight
		
		[Constructable]
		public QuiverOfBlight() : base()
		{
			Hue = 0x4F3;

			WeightReduction = 30;
		}

		public QuiverOfBlight( Serial serial ) : base( serial )
		{
		}

		public override void AlterBowDamage( ref int phys, ref int fire, ref int cold, ref int pois, ref int nrgy, ref int chaos, ref int direct )
		{
			fire = cold = nrgy = chaos = direct = 0;
                  phys = pois = 50;
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
