using FirstTextRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTextRPG
{
    /*//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     * 
     * My text based RPG
     * Goals: Inventory System, Combat, Go area to area, Random encounters, Save system, 
     * Make it pretty much like Corruption of Champions for now, minus the sex and shite inventory system
     *
     *//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    

        //RIGHT NOW YOU DONT HAVE CHARACTER CREATION OR INVENTORY OR ANYTHING, JUST TESTING COMMANDS FROM CAMPSITE BEFORE WE GO ANYWHERE ELSE.
    class Program
    {
         
        static void Main(string[] args)
        {
            //instnaciate classes
            GameStart gameStart = new GameStart();
            CampSite campSite = new CampSite();

            //intro to game, ask if they want new game or existing save
            while(gameStart.introChecked == false)
            {
                Console.WriteLine(gameStart.introText); //Asks player if they want to start a new game

                gameStart.introAnswerChecker(Console.ReadLine()); //Check for response
            }
            //TODO: add character creation and classes here, for now we running default, jack shit
            Console.Clear(); //clears console
            Console.WriteLine(campSite.campQuestion); //bringing player to campsite and asking them what they want to do
                Console.ReadKey(); //makes user hit any key to exit
        }
    }
}
