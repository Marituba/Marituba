using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure
{
    internal class Program

    {
        public static string choice { get; private set; }
        public static string playerName;
        public static string broom;
        public static int playerHealt = 10;
        public static int playerDmg = 1;
        public static int raccoonHealt = 10;
        public static int raccoonDmg = 1;
       

        static void Main(string[] args)
        {
            gameTitle();
        }
        public static void gameTitle()
        { 
            Console.WriteLine("Welcome to my first game");

            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            Console.WriteLine("Hello " + playerName,", please press enter to continue");
            Console.ReadLine();


            Console.Clear();
            Pokoj();
         }
       public static void Pokoj()
        {
            string choice;
            Console.WriteLine("You wake up in your comfy bed");
            Console.WriteLine("There is some errads you need to run today fam");
            Console.WriteLine("To do that, you need to get out of the house");
            Console.WriteLine("But the bed is so comfortable that you dont want to leave it");
            Console.WriteLine("Whad do you do?");
            Console.WriteLine("1. Get out of the bed");
            Console.WriteLine("2. Stay in the bed a little longer");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "g":
                case "get out":
                case "get out of the bed":
                    {
                        Console.WriteLine("You fight the urge to go back to sleep and get up");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        obyvak();
                        break;
                    }
                case "2":
                case "s":
                case "stay in":
                case "stay in the bed a little longer":
                    {
                        Console.WriteLine("You stayed in the bed and few moment later you are already dreaming about love,death and robots");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        gameOver();
                        break;
                        }
                default :
                    {
                        Console.WriteLine("Try something else press Enter to continue");
                        Console.ReadLine();
                        Pokoj();
                        break;
                    }
            }

            
        }
        public static void obyvak()
        {
            String choice2;
            

            Console.WriteLine("You are in your living room.");
            Console.WriteLine("There is no time in admiring your fancy house, at max you can look out of your window, for some reason there is a rope on your table. Otherwise its time to go");
            Console.WriteLine("what do you want to do?");
            Console.WriteLine("1. Look out the window");
            Console.WriteLine("2. Take the rope");
            Console.WriteLine("3. Leave the room and get out");
            Console.Write("Choice: ");
            choice2 = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choice2)
            { 
                case "1":
                case "look":
                case "window":
                case "w":
                    {
                        Console.WriteLine("Magnificen view, in theory you could try to climb out of the window.");
                        Console.WriteLine("but why? you decide that you have seen enough");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        predsin();
                        break;
                    }
                case "2":
                case "rope":
                case "take rope":
                case "r":
                    {
                        String choice3;
                        Console.WriteLine("you look at the rope, its at least 15m long");
                        Console.WriteLine("Why its here? you dont know, but if you are feeling adventurous, maybe you could climb out of the window with it");
                        Console.WriteLine("Do you wanna try? Yes or No?");
                        choice3 = Console.ReadLine().ToLower();
                        
                        if (choice3 == "yes" || choice3 == "y")
                        {
                            
                            Console.WriteLine("You go for it and climb out of the window.");
                            win();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not today");
                            predsin();
                            break;
                        }
                       


                    }
                case "3":
                case "leave":
                case "get out":
                    {
                        Console.WriteLine("you dont have time for any of this nonsence and decided to leave");
                        predsin();
                        break;

                    }
                    default :
                    {
                        Console.WriteLine("Try something else press Enter to continue");
                        Console.ReadLine();
                        obyvak();
                        break;
                    }
                   

            }
            

        }
        
        public static void predsin()
        {
            String choice4;
            Console.WriteLine("After getting your shoes on, you are ready to leave.");
            Console.WriteLine("There is a closet.");
            Console.Write("Do you want to look inside or leave?");
            choice4 = Console.ReadLine().ToLower();
            Console.Clear();
            switch(choice4)
            {
                case "inside":
                case "look":
                case "1":
                case "i":
                    {
                        Console.WriteLine("in the closet you found a broom, wanna take it?");
                        Console.WriteLine("Yes or No?");
                        broom = Console.ReadLine().ToLower();

                        if (broom == "yes")
                        {
                            
                            Console.WriteLine("You have taken the broom and are ready to leave the house");
                            dvereBroom();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nope, why would you need a broom if you are leaving the house.");
                            Console.WriteLine("You are ready to leave the house without the broom");
                            dvere();
                            break;
                        }

                    }
                case "leave":
                case "l":
                case "no":
                case "n":
                    {
                        Console.WriteLine("Time to leave, your closet inspection can wait another day");
                        dvere();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Try something else press Enter to continue");
                        Console.ReadLine();
                        predsin();
                        break;
                    }

            }
        }
        public static void dvere()
        {
            string battle;
            Console.WriteLine("After you opened the door, there is...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Giant Raccoon that is blocking you path");
            Console.WriteLine("It looks like he is ready to fight");
            Console.WriteLine("Will you face him?");
            Console.ForegroundColor = ConsoleColor.Gray;
            battle = Console.ReadLine().ToLower();
            
            //v tehle casti jsem se nejak zamotal a nevim proc to az k else nefunguje
             if (battle == "yes" || battle == "y")
                Console.WriteLine("After measuring him up, you think you can defeat him");
            {
                do
                {

                    Random dmg1 = new Random();
                    int playerPower = (dmg1.Next(1, 3) * playerDmg);
                    raccoonHealt = raccoonHealt - playerPower;

                    Random dmg2 = new Random();
                    int raccoonPower = (dmg2.Next(1, 3) * raccoonDmg);
                    playerHealt = playerHealt - raccoonPower;

                }
                while (playerHealt > 0 && raccoonHealt > 0);
            }
           
            // tady mi to vzdy vyprodukuje prvni if a finalni else to ignoruje, proc?
            if (raccoonHealt == 0)
            {
                Console.WriteLine(" The fight was long but in the end you defeated the raccoon and can leave the house in peace");
                Console.ReadLine();
                Console.Clear();
                win();
            }
            else if (playerHealt == 0)
            { Console.WriteLine("The raccoon proved to be too strong for you and defeated you");
                Console.ReadLine();
                Console.Clear();
                gameOver();
            }
            else 
            {
                Console.WriteLine(" On second look he seems too beefy to take head on, you decide to get back in the house");
                Console.ReadLine();
                Console.Clear();
                    predsin();

            }

        }
        
        public static void gameOver()
        {
            string restart;
            Console.WriteLine("You didnt make it");
            Console.WriteLine("Do you want to try again?");
            restart = Console.ReadLine().ToLower();
            if (restart == "yes" || restart == "y")
                Pokoj();
            Console.Clear();

        }
        public static void dvereBroom()
        {
            Console.WriteLine("After opening the door, you found big raccoon blocking your path, luckily with you trusty broom, he was no match and you push him away");
            Console.ReadLine();
            Console.Clear();
            win();
        }
        public static void win()
        {
            Console.WriteLine("Congratulation "+playerName+", you win!");
            Console.ReadLine();
        }
        
        
    }

}

