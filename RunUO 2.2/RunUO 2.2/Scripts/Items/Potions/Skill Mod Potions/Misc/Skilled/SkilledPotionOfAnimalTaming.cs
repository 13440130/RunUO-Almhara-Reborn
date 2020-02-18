using System;
using Server;
using Server.Network;
using Server.Items;
using System.Collections;

namespace Server.Items
{
	public class SkilledPotionOfAnimalTaming : BasePotion
	{ 
		[Constructable]
		public SkilledPotionOfAnimalTaming() : base( 0xE29, PotionEffect.Heal )
		{
			Name = "Skilled Potion of Animal Taming";
			Hue = 285;
		}

		public SkilledPotionOfAnimalTaming( Serial serial ) : base( serial )
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

            public override void Drink(Mobile from)
            {
				if ( from.BeginAction( typeof( BaseHealPotion ) ) )
				{

                          from.AddSkillMod(new TimedSkillMod(SkillName.AnimalTaming, true, 25.0, TimeSpan.FromMinutes(5.0)));
			  from.SendMessage( "You have gained a major temporary boost to your Animal Taming skill." );

			  BasePotion.PlayDrinkEffect( from );
			  from.PlaySound( 0x5C8 );

			  this.Delete();

					Timer.DelayCall( TimeSpan.FromMinutes( 5.0 ), new TimerStateCallback( ReleaseHealLock ), from );
				}
				else
				{
					from.SendMessage( "You must wait 5 minutes before using another potion of this caliber." );
				}
			}
	
		private static void ReleaseHealLock( object state )
		{
			((Mobile)state).EndAction( typeof( BaseHealPotion ) );
		}
	}
}