using System;
using System.Collections;
using Server;
using Server.Gumps;
using Server.Multis;
using Server.Network;
using Server.ContextMenus;
using Server.Engines.PartySystem;

namespace Server.Items
{
        [Flipable( 0xE43, 0xE42 )]
	public class IguanaCoveBossChest : LockableContainer
	{
                public override bool Decays{ get{ return true; } } 

                public override TimeSpan DecayTime{ get{ return TimeSpan.FromMinutes( Utility.Random( 30, 60 ) ); } }

                public override int DefaultGumpID{ get{ return 0x49; } }
                public override int DefaultDropSound{ get{ return 0x42; } }

                public override Rectangle2D Bounds
                {
                      get{ return new Rectangle2D( 18, 105, 144, 73 ); }
                }

                [Constructable]
                public IguanaCoveBossChest() : base( 0xE43 )
                {
		        Name = "a treasure chest -50-";
		        Movable = true;
		        Weight = 1000.0;

                        TrapPower = 0;
                        Locked = true;

                        RequiredSkill = 50;
                        LockLevel = 50;
                        MaxLockLevel = 80;

/////////////////////////////////// Gold
 		        if ( Utility.RandomDouble() < 0.25 )
                          	DropItem( new Gold( Utility.Random( 250, 400 ) ) );

/////////////////////////////////////// Jewelry

 			if ( Utility.RandomDouble() < 0.04 )
            			DropItem( new Agate() );
 			if ( Utility.RandomDouble() < 0.04 )
            			DropItem( new Beryl() );
 			if ( Utility.RandomDouble() < 0.04 )
            			DropItem( new ChromeDiopside() );
 			if ( Utility.RandomDouble() < 0.04 )
            			DropItem( new FireOpal() );
 			if ( Utility.RandomDouble() < 0.04 )
            			DropItem( new MoonstoneCustom() );
 			if ( Utility.RandomDouble() < 0.04 )
            			DropItem( new Onyx() );
 			if ( Utility.RandomDouble() < 0.04 )
            			DropItem( new Opal() );
 			if ( Utility.RandomDouble() < 0.04 )
            			DropItem( new Pearl() );
 			if ( Utility.RandomDouble() < 0.04 )
            			DropItem( new TurquoiseCustom() );

 			if ( Utility.RandomDouble() < 0.03 )
            			DropItem( new Bloodstone() );
 			if ( Utility.RandomDouble() < 0.03 )
            			DropItem( new Citrine() );
 			if ( Utility.RandomDouble() < 0.03 )
            			DropItem( new Demantoid() );
 			if ( Utility.RandomDouble() < 0.03 )
            			DropItem( new Jasper() );
 			if ( Utility.RandomDouble() < 0.03 )
            			DropItem( new Lolite() );
 			if ( Utility.RandomDouble() < 0.03 )
            			DropItem( new Lupis() );
 			if ( Utility.RandomDouble() < 0.03 )
            			DropItem( new Peridot() );
 			if ( Utility.RandomDouble() < 0.03 )
            			DropItem( new Tsavorite() );
 			if ( Utility.RandomDouble() < 0.03 )
            			DropItem( new Zircon() );

 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Amber() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Amethyst() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Andalusite() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Chrysoberyl() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Garnet() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Jade() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Mandarin() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Morganite() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Paraiba() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new TigerEye() );
 			if ( Utility.RandomDouble() < 0.02 )
            			DropItem( new Tourmaline() );

 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Alexandrite() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Ametrine() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Kunzite() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Ruby() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Sapphire() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Tanzanite() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Topaz() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Zultanite() );

 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Diamond() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new Emerald() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new PinkQuartz() );
 			if ( Utility.RandomDouble() < 0.01 )
            			DropItem( new StarSapphire() );

/////////////////////////////////////// Supplies

			switch ( Utility.Random( 18 ) )
			{
				case 0: DropItem( new Board(80) ); break;
				case 1: DropItem( new BoltOfCloth(80) ); break;
				case 2: DropItem( new Bottle(80) ); break;
				case 3: DropItem( new CopperWire(80) ); break;
				case 4: DropItem( new Cotton(80) ); break;
				case 5: DropItem( new DarkYarn(80) ); break;
				case 6: DropItem( new Feather(80) ); break;
				case 7: DropItem( new Flax(80) ); break;
				case 8: DropItem( new Gears(80) ); break;
				case 9: DropItem( new GoldWire(80) ); break;
				case 10: DropItem( new IronIngot(80) ); break;
				case 11: DropItem( new IronWire(80) ); break;
				case 12: DropItem( new Leather(80) ); break;
				case 13: DropItem( new LightYarn(80) ); break;
				case 14: DropItem( new Shaft(80) ); break;
				case 15: DropItem( new SilverWire(80) ); break;
				case 16: DropItem( new SpoolOfThread(80) ); break;
				case 17: DropItem( new Springs(80) ); break;
				case 18: DropItem( new Wool(80) ); break;
			}

			switch ( Utility.Random( 5 ) )
			{
				case 0: DropItem( new ArcaneStone(25) ); break;
				case 1: DropItem( new BeetleEgg(25) ); break;
				case 2: DropItem( new DragonScale(25) ); break;
				case 3: DropItem( new FishScale(25) ); break;
				case 4: DropItem( new SerpentScale(25) ); break;
			}

                        Item ReagentLoot = Loot.RandomReagent();
                        ReagentLoot.Amount = Utility.RandomMinMax( 50, 100 );
                         DropItem( ReagentLoot );

 		        if ( Utility.RandomDouble() < 0.05 )
		                DropItem( new SackFlour() );

/////////////////////////////////////// Rare Items

 		      if ( Utility.RandomDouble() < 0.01 )
		         DropItem( new DyeTub() );

/////////////////////////////////////// LV 20-30
 		      if ( Utility.RandomDouble() < 0.10 )
                      {
	                       BaseWeapon weapon = Loot.RandomWeapon( true );
			       switch ( Utility.Random( 31 ) )
			       {
				        case 0: weapon = new DoubleAxe(); break; // Lv20
				        case 1: weapon = new TwoHandedAxe(); break; // Lv25
				        case 2: weapon = new WarAxe(); break; // Lv30
				        case 3: weapon = new CompositeBow(); break; // Lv20
				        case 4: weapon = new EbonyCrossbow(); break; // Lv20
				        case 5: weapon = new FireBow(); break; // Lv25
				        case 6: weapon = new GrassBow(); break; // Lv25
				        case 7: weapon = new IceBow(); break; // Lv25
				        case 8: weapon = new LightningBow(); break; // Lv25
				        case 9: weapon = new EbonyWarBow(); break; // Lv30
				        case 10: weapon = new PistolCrossbow(); break; // Lv30
				        case 11: weapon = new EbonyDualDaggers(); break; // Lv20
				        case 12: weapon = new Tekagi(); break; // Lv25
				        case 13: weapon = new ElvenSpellblade(); break; // Lv30
				        case 14: weapon = new WarMace(); break; // Lv20
				        case 15: weapon = new Tessen(); break; // Lv25
				        case 16: weapon = new HammerPick(); break; // Lv30
				        case 17: weapon = new Spear(); break; // Lv20
				        case 18: weapon = new BoneSpear(); break; // Lv25
				        case 19: weapon = new BubbleStaff(); break; // Lv25
				        case 20: weapon = new CrystalStaff(); break; // Lv25
				        case 21: weapon = new EnergyStaff(); break; // Lv25
				        case 22: weapon = new FireStaff(); break; // Lv25
				        case 23: weapon = new VineStaff(); break; // Lv25
				        case 24: weapon = new BlackStaff(); break; // Lv30
				        case 25: weapon = new VikingSword(); break; // Lv20
				        case 26: weapon = new Wakizashi(); break; // Lv20
				        case 27: weapon = new Daisho(); break; // Lv30
				        case 28: weapon = new EbonyScimitar(); break; // Lv30
				        case 29: weapon = new RuneBlade(); break; // Lv30
				        default: weapon = new Longsword(); break; // Lv20
			       }

			       BaseRunicTool.ApplyAttributesTo( weapon, 2, 5, 50 );
			       DropItem( weapon );
			}

/////////////////////////////////////// LV 18-27
 		        if ( Utility.RandomDouble() < 0.10 )
                        {
			        BaseArmor armor = Loot.RandomArmor( true );
			        switch ( Utility.Random( 18 ) )
			        {
			                case 0: armor = new HideFemaleChest(); break; // Lv18
			                case 1: armor = new HideGloves(); break; // Lv18
				        case 2: armor = new HideGorget(); break; // Lv18
				        case 3: armor = new HidePants(); break; // Lv18
				        case 4: armor = new HidePauldrons(); break; // Lv18
			                case 5: armor = new StuddedDo(); break; // Lv21
			                case 6: armor = new StuddedHaidate(); break; // Lv21
				        case 7: armor = new StuddedHiroSode(); break; // Lv21
				        case 8: armor = new StuddedMempo(); break; // Lv21
				        case 9: armor = new StuddedSuneate(); break; // Lv21
			                case 10: armor = new VikingStuddedArms(); break; // Lv24
				        case 11: armor = new VikingStuddedCap(); break; // Lv24
				        case 12: armor = new VikingStuddedChest(); break; // Lv24
				        case 13: armor = new VikingStuddedLegs(); break; // Lv24
				        case 14: armor = new ChainChest(); break; // Lv27
				        case 15: armor = new ChainCoif(); break; // Lv27
				        case 16: armor = new ChainLegs(); break; // Lv27
				        default: armor = new HideChest(); break; // Lv18
		                }

			        BaseRunicTool.ApplyAttributesTo( armor, 3, 5, 50 );
				DropItem( armor );
			}

 		        if ( Utility.RandomDouble() < 0.10 )
                        {
	                       BaseHat hat = Loot.RandomHat( true ); 
		               BaseRunicTool.ApplyAttributesTo( hat, 3, 12, 15 );
		               DropItem( hat );
		        }
 		        if ( Utility.RandomDouble() < 0.10 )
                        {
			       BaseClothing clothing = Loot.RandomClothing( true );
		               BaseRunicTool.ApplyAttributesTo( clothing, 3, 12, 15 );
                               DropItem( clothing );
                        }

 		        if ( Utility.RandomDouble() < 0.05 )
                        {
			       BaseShield shield1 = new MetalShield();
			       if ( Core.AOS )
		               BaseRunicTool.ApplyAttributesTo( shield1, 3, 5, 50 );              
                               DropItem( shield1 );
                        }
 		        if ( Utility.RandomDouble() < 0.05 )
                        {
			       BaseShield shield2 = new WoodenKiteShield();
			       if ( Core.AOS )
		               BaseRunicTool.ApplyAttributesTo( shield2, 3, 5, 50 );              
                               DropItem( shield2 );
                        }
 		        if ( Utility.RandomDouble() < 0.05 )
                        {
			       BaseShield shield3 = new MetalKiteShield();
			       if ( Core.AOS )
		               BaseRunicTool.ApplyAttributesTo( shield3, 3, 5, 50 );              
                               DropItem( shield3 );
                        }

 		        if ( Utility.RandomDouble() < 0.10 )
                        {
			       BaseJewel bracelet = new SilverBracelet();
			       if ( Core.AOS )
		               BaseRunicTool.ApplyAttributesTo( bracelet, 3, 12, 15 );              
                               DropItem( bracelet );
                        }
 		        if ( Utility.RandomDouble() < 0.10 )
                        {
			       BaseJewel earrings = new SilverEarrings();
			       if ( Core.AOS )
		               BaseRunicTool.ApplyAttributesTo( earrings, 3, 12, 15 );              
                               DropItem( earrings );
                        }
 		        if ( Utility.RandomDouble() < 0.10 )
                        {
			       BaseJewel necklace = new SilverNecklace();
			       if ( Core.AOS )
		               BaseRunicTool.ApplyAttributesTo( necklace, 3, 12, 15 );              
                               DropItem( necklace );
                        }
 		        if ( Utility.RandomDouble() < 0.10 )
                        {
			       BaseJewel ring = new SilverRing();
			       if ( Core.AOS )
		               BaseRunicTool.ApplyAttributesTo( ring, 3, 12, 15 );              
                               DropItem( ring );
                        }
                }

                public IguanaCoveBossChest( Serial serial ) : base( serial )
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