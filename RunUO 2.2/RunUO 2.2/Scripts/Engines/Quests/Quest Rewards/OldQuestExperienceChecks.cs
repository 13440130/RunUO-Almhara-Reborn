using System;
using System.Collections.Generic;
using System.Text;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
	public class OldQuestExperienceCheck500 : Item
	{
		[Constructable]
		public OldQuestExperienceCheck500() : base( 0x14F0 )
		{
			Name = "Experience Check - (+500 XP)";
			LootType = LootType.Blessed;
			Weight = 0.1;
		}

		public override void OnDoubleClick( Mobile from )
		{
			PlayerMobile pm = from as PlayerMobile;

                        pm.Exp += 500;
                        pm.KillExp += 500;

                        pm.SendMessage("You've gained 500 exp.");

                        if (pm.Exp >= pm.LevelAt && pm.Level != pm.LevelCap)
                        {
                                Actions.DoLevel(pm, new Setup());
                        }

			Delete( );
		}

		public OldQuestExperienceCheck500( Serial serial ) : base( serial )
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
	}

	public class OldQuestExperienceCheck1000 : Item
	{
		[Constructable]
		public OldQuestExperienceCheck1000() : base( 0x14F0 )
		{
			Name = "Experience Check - (+1000 XP)";
			LootType = LootType.Blessed;
			Weight = 0.1;
		}

		public override void OnDoubleClick( Mobile from )
		{
			PlayerMobile pm = from as PlayerMobile;

                        pm.Exp += 1000;
                        pm.KillExp += 1000;

                        pm.SendMessage("You've gained 1000 exp.");

                        if (pm.Exp >= pm.LevelAt && pm.Level != pm.LevelCap)
                        {
                                Actions.DoLevel(pm, new Setup());
                        }

			Delete( );
		}

		public OldQuestExperienceCheck1000( Serial serial ) : base( serial )
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
	}

	public class OldQuestExperienceCheck1500 : Item
	{
		[Constructable]
		public OldQuestExperienceCheck1500() : base( 0x14F0 )
		{
			Name = "Experience Check - (+1500 XP)";
			LootType = LootType.Blessed;
			Weight = 0.1;
		}

		public override void OnDoubleClick( Mobile from )
		{
			PlayerMobile pm = from as PlayerMobile;

                        pm.Exp += 1500;
                        pm.KillExp += 1500;

                        pm.SendMessage("You've gained 1500 exp.");

                        if (pm.Exp >= pm.LevelAt && pm.Level != pm.LevelCap)
                        {
                                Actions.DoLevel(pm, new Setup());
                        }

			Delete( );
		}

		public OldQuestExperienceCheck1500( Serial serial ) : base( serial )
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
	}

	public class OldQuestExperienceCheck2000 : Item
	{
		[Constructable]
		public OldQuestExperienceCheck2000() : base( 0x14F0 )
		{
			Name = "Experience Check - (+2000 XP)";
			LootType = LootType.Blessed;
			Weight = 0.1;
		}

		public override void OnDoubleClick( Mobile from )
		{
			PlayerMobile pm = from as PlayerMobile;

                        pm.Exp += 2000;
                        pm.KillExp += 2000;

                        pm.SendMessage("You've gained 2000 exp.");

                        if (pm.Exp >= pm.LevelAt && pm.Level != pm.LevelCap)
                        {
                                Actions.DoLevel(pm, new Setup());
                        }

			Delete( );
		}

		public OldQuestExperienceCheck2000( Serial serial ) : base( serial )
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
	}
}