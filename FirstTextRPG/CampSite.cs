using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTextRPG
{
    /*//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     * 
     * This is the campsite, this will be the player's base, like corruption of champions
     *
     *//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    class CampSite
    {
        //this will be all of the explored places, maybe
        public enum exploredPlaces
        {
            P_shudila,
            B_plains
        }

        //ask the userwhat it is they want to do
        public String campQuestion = "What would you like to do? EXPLORE/SAVE/EXIT/INVENTORY/SKILLS/EQUIPMENT";
        
        //explore command
        public void Explore(String input)
        {
            if (input.ToLower() == "explore")
            {
                /*///////////////////////////////////////////////////////////////////////////////////////////////////////
                 * 
                 * use random number generator to explore, each biome should have a % chance to find
                 * also have a % chance for combat or finding a place within the biome
                 * and a % chance to find nothing, but make it lower than combat, by alot
                 * make some biomes require certain amount of exploration, like corruption of champions
                 * for now, we just test random encounter, or hardcore exploring shudila and the plains
                 * the explore command should do a basic explore when nothing is unlocked, later the user
                 * should be able to explore specific biomes and go to specific places with the places command
                 * 
                 *///////////////////////////////////////////////////////////////////////////////////////////////////////

                Console.WriteLine("You journey from your campsite, just outside of the forest and discover the plains.");
            }
        } //public void Explore(String input)
    } //class CampSite
} //namespace FirstTextRPG
