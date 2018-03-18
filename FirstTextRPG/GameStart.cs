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
    * This is for the start of the game
    * This will ask the user if they want to start a new game
    * If yes, let them make a new game
    * If no, ask if they want to load an existing save
    * Else, tell them to do yes or no
    *
    *//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    class GameStart
    {
        //Text for intro, this asks if they want to start a new game
        public String introText = "Welcome, would you like to start a new game? Y/N"; //basic question
        public Boolean introChecked = false; //need this to reask after false answers

        public void introAnswerChecker(String input)
        {
            if (input == "y" || input == "Y") //checks for yes
            {
                //TESTLINE
                Console.WriteLine("YES HAS BEEN ENTERED");
                introChecked = true;
            } //checks for yes
            else if (input == "n" || input == "N") //Checks for no
            {
                //TESTLINE
                Console.WriteLine("NO HAS BEEN ENTERED");
                //line commented because save games arent in yet, so hitting no would act as yes until this is implemented
                //introChecked = true;
                Console.ReadKey(); //Hold an input so user can read
                Console.Clear(); //Clear console
            } //Checks for no
            else //checks for invalid inputs
            {
                //Tells user their input was invalid
                Console.WriteLine("Invalid Input, try Y or N");
                Console.ReadKey(); //Hold an input so user can read
                Console.Clear(); //Clear console
            } //checks for invalid inputs
        } //public void introAnswerChecker(String input)
    } //class GameStart
} //namespace FirstTextRPG

