using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
namespace Spil
{
    class Program
    {
        //Human     : Health Points x > Human r from the planet of Earth. They are the dominant species on Earth. Throughout years of training and battling amongst themselfes, they have become incredibly strong in hand to hand combat. With increased Health point.
        //Dwarf     : Strength x > Dwarfs r from the planet of Earth. They are the small folk in the midst of countries full of human, They have longed to be the strongest and thus, They get additional strength.
        //Kennocks  : Defence x > Kennocks r Giants of the planet of feadilous. Their skin has been trained to be extremely hard, thus their Defence lvl, is higher then usual.
        //Elf       : Chance to Crit x > Elf's r the woodmen of the planet WaChen. They are extremely quick on their feet, and thus have a better chance of critical hits.
        static void Main(string[] args)
        {
            //ARNDT FINAL BOSS..SPELL 1: ARNDTIFIED
            Console.SetWindowSize(80, 30);
            Console.CursorVisible = false;
            #region Variabler

            //UI//
            string tvkant = "╔";      //Top venstre kant på ramme
            string thkant = "╗";     //Top højre kant på ramme            
            string bvkant = "╚";    //Bund venstre kant på ramme
            string bhkant = "╝";   //Bund højre kant på ramme
            string vside = "║";   //Venstre side på ramme
            string hside = "║";  //Højre side på ramme
            string top = "═";   //Top på ramme
            string bund = "═"; //Bund på ramme
            string load = "█";     //Load Bar
            string face = "░"; // FACE
            //UI//

            //General
            int PlayerHP = 100;
            int BossOneHP = 200;
            int Strength = 0;
            int Defence = 0;
            int CritChance = 0;
            //Generalslut
            //STRINGS
            string Humans;
            string Dwarf;
            string Kennocks;
            string elf;
            string Turain;

            //RACEVALG
            string race;
            bool racebool = false;
            //RACEVALGSLUT

            //CLASSVALGSTART

            bool SoldierBool = false;
            bool VanguardBool = false;
            bool ArcherBool = false;
            bool WarlockBool = false;
            string ClassSpecial = "Potion";
            string Class;
            bool Classbool = false;
            //CLASSVALGSLUT

            //BLACKSMITH

            Random rnd = new Random();
            int rndweapon = rnd.Next(3);
            string weaponchoosen;
            string Weapon;
            string WeaponvalgtONE;
            string AccessorieONE;
            string BlacksmithCASE;
            string Melee;
            string Range;
            string Accessories;
            bool Blacksmith = true;
            bool Meleebool = true;
            bool Rangebool = true;
            bool accessoriesbool = true;

            //BLACKSMITHSLUT

            //DUNGEONSONESTART

            bool dungeonONEbool = true;
            string Captain_Obvious;
            string dungeonOne;
            
            //Wizard of Direction.

            string ChooseDirection;
            bool Left = false;
            bool Right = false;

            //Wizard of DirectionSLUT


            //DUNGEONSONESLUT

            //STRINGS SLUT
            #endregion
            #region INTRO
            Console.WriteLine("Welcome to the Game of neverending adventure.");
            Console.WriteLine("First, Choose your race:");
            Console.WriteLine(" ");
            Console.WriteLine("Human");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Health Points: + 20");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Dwarf");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Strength: + 3 ");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("Kennocks");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Defence + 3");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Elf");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Crit Chance + 5%");
            Console.SetCursorPosition(0, 11);
            #endregion
            #region CHOOSE RACE
            //ZZZZZZZZZZZZZZZZZZZZZZZZZRACESELECTION-START-ZZZZZZZZZZZZZZZZZZZZZZZZZ
            do
            {
                race = Console.ReadLine();
                Console.SetCursorPosition(0, 0);
                switch (race.ToUpper())
                {
                    case "HUMAN":
                        race = "Human";
                        PlayerHP = PlayerHP + 20;
                        racebool = false;
                        break;
                    case "DWARF":
                        race = "Dwarf";
                        Strength = Strength + 3;
                        racebool = false;
                        break;
                    case "KENNOCKS":
                        race = "Kennocks";
                        Defence = 3;
                        racebool = false;
                        break;
                    case "ELF":
                        race = "Elf";
                        CritChance = 5;
                        racebool = false;
                        break;
                    default:
                        Console.WriteLine("Something, Somewhere went wrong");
                        racebool = true;
                        break;
                }
            }
            while (racebool);


            //ZZZZZZZZZZZZZZZZZZZZZZZZZRACESELECTION-END-ZZZZZZZZZZZZZZZZZZZZZZZZZ
            #endregion
            #region CHOOSE CLASS
            Console.Clear();
            Console.WriteLine("You have chosen {0}", race);
            Console.WriteLine("Now, choose a Class");
            Console.WriteLine(" ");
            Console.WriteLine("Soldier");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Strength + 2");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Health Points + 25");

            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Vanguard");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Strength + 1");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("Health Points + 50");

            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Archer");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Strength + 4");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("Health Points + 15");

            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Warlock");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("Strength + 6");
            Console.SetCursorPosition(3, 14);
            Console.WriteLine("Health Points + 10");

            Console.SetCursorPosition(0, 15);

            do
            {
                Class = Console.ReadLine();
                switch (Class.ToUpper())
                {
                    case "SOLDIER":
                        Class = "Soldier";
                        SoldierBool = true;
                        Classbool = false;
                        Strength = Strength + 3;
                        PlayerHP = PlayerHP + 25;
                        break;
                    case "VANGUARD":
                        Class = "Vanguard";
                        VanguardBool = true;
                        Classbool = false;
                        PlayerHP = PlayerHP + 50;
                        Strength = Strength + 1;
                        break;
                    case "ARCHER":
                        Class = "Archer";
                        ArcherBool = true;
                        Classbool = false;
                        Strength = Strength + 4;
                        PlayerHP = PlayerHP + 15;
                        break;
                    case "WARLOCK":
                        Class = "Warlock";
                        WarlockBool = true;
                        Classbool = false;
                        PlayerHP = PlayerHP + 5;
                        Strength = Strength + 6;
                        break;
                    default:
                        Console.WriteLine("Something, Somewhere went wrong");
                        Classbool = true;
                        break;
                }
            }
            while (Classbool);
            #endregion
            #region CHOOSE WEAPONS
            do
            {
                Console.Clear();

                Console.WriteLine("Choose your Weapon!.");
                #region Blacksmith Soldier
                if (SoldierBool == true)
                {
                    Console.WriteLine("type in the number of the weapon you want");
                    Console.WriteLine("1. Sword @ 2Hander");
                    Console.WriteLine("2. Sword and Shield");
                    weaponchoosen = Console.ReadLine();
                    if (weaponchoosen == "1")
                    {
                        Weapon = "2H Sword";
                        Strength = Strength + 8;
                        Blacksmith = false;
                    }
                    else if (weaponchoosen == "2")
                    {
                        Weapon = "Sword & Shield";
                        Strength = Strength + 5;
                        PlayerHP = PlayerHP + 20;
                        Blacksmith = false;
                    }
                    else
                    {
                        Weapon = " ";
                        Console.WriteLine("Incorrect! - Please try again.");
                        Blacksmith = true;
                    }
                }
                #endregion
                #region Blacksmith Vanguard
                else if (VanguardBool == true)
                {
                    Console.WriteLine("type in the number of the weapon you want");
                    Console.WriteLine("1. Mace @ 2Hander");
                    Console.WriteLine("2. Hammer @ 2Hander");
                    Console.WriteLine("3. Spear and Shield");
                    weaponchoosen = Console.ReadLine();
                    if (weaponchoosen == "1")
                    {
                        Weapon = "2H Mace";
                        Strength = Strength + 8;
                        Blacksmith = false;
                    }
                    else if (weaponchoosen == "2")
                    {
                        Weapon = "2H Hammer";
                        Strength = Strength + 8;
                        Blacksmith = false;
                    }
                    else if (weaponchoosen == "3")
                    {
                        Weapon = "Spear & Shield";
                        Strength = Strength + 2;
                        PlayerHP = PlayerHP + 20;
                        Blacksmith = false;
                    }
                    else
                    {
                        Weapon = " ";
                        Console.WriteLine("Incorrect! - Please try again.");
                        Blacksmith = true;
                    }
                }
                #endregion
                #region Blacksmith Archer
                else if (ArcherBool == true)
                {
                    Console.WriteLine("type in the number of the weapon you want");
                    Console.WriteLine("1. Bow & Arrow");
                    Console.WriteLine("2. Crossbow & Arrow");
                    Console.WriteLine("3. Slingshot & Rocks");
                    weaponchoosen = Console.ReadLine();
                    if (weaponchoosen == "1")
                    {
                        Weapon = "Bow & Arrows";
                        Strength = Strength + 8;
                        Blacksmith = false;
                    }
                    else if (weaponchoosen == "2")
                    {
                        Weapon = "CrossBow & Arrows";
                        Strength = Strength + 8;
                        Blacksmith = false;
                    }
                    else if (weaponchoosen == "3")
                    {
                        Weapon = "Slingshot & Rocks";
                        Strength = Strength + 5;
                        PlayerHP = PlayerHP + 35;
                        Blacksmith = false;
                    }
                    else
                    {
                        Weapon = " ";
                        Console.WriteLine("Incorrect! - Please try again.");
                        Blacksmith = true;
                    }
                }
                #endregion
                #region Blacksmith Warlock
                else if (WarlockBool == true)
                {
                    Console.WriteLine("type in the number of the weapon you want");
                    Console.WriteLine("1. Wand & Shield");
                    Console.WriteLine("2. Staff of Pure Power");
                    weaponchoosen = Console.ReadLine();
                    if (weaponchoosen == "1")
                    {
                        Weapon = "Wand & Shield";
                        Strength = Strength + 5;
                        PlayerHP = PlayerHP + 50;
                        Blacksmith = false;
                    }
                    else if (weaponchoosen == "2")
                    {
                        Weapon = "Staff of Pure Power";
                        Strength = Strength + 10;
                        Blacksmith = false;
                    }
                    else
                    {
                        Weapon = " ";
                        Console.WriteLine("Incorrect! - Please try again.");
                        Blacksmith = true;
                    }
                }
                #endregion
                #region Blacksmith else
                else
                {
                    Weapon = " ";
                    Console.WriteLine("Uhm, Try again.");
                    Weapon = Console.ReadLine();
                }
            }
                #endregion
            while (Blacksmith);
            #endregion
            Console.Clear();
            #region Golem - Fight One.
            //ZZZZZZZZZZZZZZZZZZZZ----DUNGEONSTART----ZZZZZZZZZZZZZZZZZZZZZZ

            Console.WriteLine("YOU HAVE ENCOUNTERED AN EVIL GOLEM. PREPARE YOURSELF.");
            Console.WriteLine("It's Time to fight, Click anykey to continue!");
            Console.ReadKey();
            while (BossOneHP > 0 & PlayerHP > 0)
            {
                Console.Clear();
                Console.WriteLine("You can either, Fight or use your Potion");
                Console.WriteLine("OBS: You can only use your Potion once, unless of course you find another...");
                #region UI

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                for (int i = 0; i < 78; i++)
                {
                    Console.SetCursorPosition(1 + i, 19);
                    Console.Write(top);
                }
                for (int j = 0; j < 78; j++)
                {
                    Console.SetCursorPosition(1 + j, 27);
                    Console.Write(bund);
                }
                for (int l = 0; l < 9; l++)
                {
                    Console.SetCursorPosition(79, 19 + l);
                    Console.Write(hside);
                }
                for (int a = 0; a < 9; a++)
                {
                    Console.SetCursorPosition(0, 19 + a);
                    Console.Write(vside);
                }
                Console.SetCursorPosition(0, 19);
                Console.Write(tvkant);
                Console.SetCursorPosition(79, 19);
                Console.Write(thkant);
                Console.SetCursorPosition(0, 27);
                Console.Write(bvkant);
                Console.SetCursorPosition(79, 27);
                Console.Write(bhkant);

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.SetCursorPosition(1, 23);
                Console.WriteLine("Race         : {0}", race);
                Console.SetCursorPosition(1, 24);
                Console.WriteLine("Class        : {0}", Class);
                Console.SetCursorPosition(1, 25);
                Console.WriteLine("Special      : {0}", ClassSpecial);
                Console.SetCursorPosition(1, 22);
                Console.WriteLine("Player HP    : {0}", PlayerHP);
                Console.SetCursorPosition(1, 21);
                Console.WriteLine("BossHP       : {0}", BossOneHP);
                Console.SetCursorPosition(1, 26);
                Console.WriteLine("Weapon       : {0}", Weapon);
                Console.SetCursorPosition(1, 27);
                //Console.WriteLine("Accessorie   : {0}", Accessorie);
                //Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 3);
                #endregion
                dungeonOne = Console.ReadLine();
                switch (dungeonOne.ToUpper())
                {
                    case "FIGHT":
                    case "ATTACK":
                        int rndPlayer = rnd.Next(5 + Strength,10 + Strength);
                        BossOneHP = BossOneHP - rndPlayer;
                        Console.WriteLine("You strike the Golem, for {0} Damage",rndPlayer);
                        Console.WriteLine("BossHP: {0}",BossOneHP);
                        System.Threading.Thread.Sleep(1500);
                        int rndPlayerExtra = rnd.Next(100);
                        if (rndPlayerExtra > 90)
                        {
                            Console.WriteLine("You get off another attack! You strike the golem, for 5 Damage");
                            BossOneHP = BossOneHP - 5;
                            System.Threading.Thread.Sleep(1000);
                        }
                        if (rndPlayerExtra < 5+CritChance)
                        {
                            Console.WriteLine("Amazing, a doubleblow! You hit for another {0}", rndPlayer);
                            BossOneHP = BossOneHP - rndPlayer;
                            System.Threading.Thread.Sleep(1000);
                        }
                        

                        int rndBoss = rnd.Next(7-Defence,10);
                        Console.WriteLine("The Golem strikes you back, for {0} Damage.", rndBoss);
                        PlayerHP = PlayerHP - rndBoss;
                        Console.WriteLine("PlayerHP: {0}", PlayerHP);
                        System.Threading.Thread.Sleep(1500);
                        break;
                    case "INSTANTLYLOOSE":
                        PlayerHP = 0;
                        break;
                    case "POTION":
                        break;
                }
            }
            
            if (PlayerHP <= 0)
            {
                Console.WriteLine("I'm Sorry. but,  you're dead.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (BossOneHP < 0)
            {
                Console.WriteLine("You have Defeated the Golem!!");
                Console.WriteLine("Press anykey to Continue...");
                Console.ReadKey();
                Console.Clear();
            }
#endregion

            //#region ChooseDirection & Wizard
            //Console.WriteLine("A wild Wizard appears..");
            //Console.WriteLine("Wizard:'Hello there, Stranger. You've defeated the golem, It is time to harvest your rewards!'");
            //Console.WriteLine("Your reward is close, but there are still obstacles to conquer, women to win, and monsters to kill.");
            //Console.WriteLine("You can go left, However, theres something, I know not what, lurking, that way. Be careful!");
            //Console.WriteLine("You can go right. However, no man has ever returned from there. Just kidding, i think it's a tavern full of gold and women.");
            //Console.WriteLine("");
            //Console.WriteLine("Tip: The wizard is a troll. Be careful with those, They cannot be trusted!");
            //Console.WriteLine("Tip: Type in the direction you want to go. eg left/right");

            //do
            //{
            //    ChooseDirection = Console.ReadLine();
            //    if (ChooseDirection == "LEFT")
            //    {
            //        Left = true;
            //        Console.WriteLine("You have choosen to go 'Left'");
            //    }
            //    else if (ChooseDirection == "RIGHT")
            //    {
            //        Right = true;
            //        Console.WriteLine("You have choosen to go 'Right'.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Something went wrong - Try either Left or Right.");
            //    }
            //    Console.ReadKey();
            //}
            //while (ChooseDirection == "RIGHT" || ChooseDirection == "LEFT");
            //#endregion 
           






        }
    }
}
