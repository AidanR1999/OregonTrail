using System;

namespace OregonTrail
{
    public class Logic
    {
        public void Start()
        {
            if(instructions() == true)
            {
                showInstructions();
            }
            else
            {  
                game();
            }
            
        }

        private void showInstructions()
        {
            log("THIS PROGRAM SIMULATES A TRIP OVER THE OREGON TRAIL FROM");
            log("INDEPENDENCE, MISSOURI TO OREGON CITY, OREGON IN 1847.");
            log("YOUR FAMILY OF FIVE WILL COVER THE 2000 MILE OREGON TRAIL");
            log("IN 5-6 MONTHS --- IF YOU MAKE IT ALIVE.");
            log();
            log("YOU HAD SAVED $900 TO SPEND FOR THE TRIP, AND YOU'VE JUST");
            log("   PAID $200 FOR A WAGON.");
            log("YOU WILL NEED TO SPEND THE REST OF YOUR MONEY ON THE");
            log("   FOLLOWING ITEMS:");
            log();
            log("     OXEN - YOU CAN SPEND $200-$300 ON YOUR TEAM");
            log("            THE MORE YOU SPEND, THE FASTER YOU'LL GO");
            log("               BECAUSE YOU'LL HAVE BETTER ANIMALS");
            log();
            log("     FOOD - THE MORE YOU HAVE, THE LESS CHANCE THERE");
            log("               IS OF GETTING SICK");
            log();
            log("     AMMUNITION - $1 BUYS A BELT OF 50 BULLETS");
            log("            YOU WILL NEED BULLETS FOR ATTACKS BY ANIMALS");
            log("               AND BANDITS, AND FOR HUNTING FOOD");
            log();
            log("     CLOTHING - THIS IS ESPECIALLY IMPORTANT FOR THE COLD");
            log("               WEATHER YOU WILL ENCOUNTER WHEN CROSSING");
            log("               THE MOUNTAINS");
            log();
            log("     MISCELLANEOUS SUPPLIES - THIS INCLUDES MEDICINE AND");
            log("               OTHER THINGS YOU WILL NEED FOR SICKNESS");
            log("               AND EMERGENCY REPAIRS");
            log();
            log();
            log("YOU CAN SPEND ALL YOUR MONEY BEFORE YOU START YOUR TRIP -");
            log("OR YOU CAN SAVE SOME OF YOUR CASH TO SPEND AT FORTS ALONG");
            log("THE WAY WHEN YOU RUN LOW.  HOWEVER, ITEMS COST MORE AT");
            log("THE FORTS.  YOU CAN ALSO GO HUNTING ALONG THE WAY TO GET");
            log("MORE FOOD.");
            log("WHENEVER YOU HAVE TO USE YOUR TRUSTY RIFLE ALONG THE WAY,");
            log("YOU WILL SEE THE WORDS: TYPE BANG.  THE FASTER YOU TYPE");
            log("IN THE WORD 'BANG' AND HIT THE 'RETURN' KEY, THE BETTER");
            log("LUCK YOU'LL HAVE WITH YOUR GUN.");
            log();
            log("WHEN ASKED TO ENTER MONEY AMOUNTS, DON'T USE A '$'.");
            log();
            log("GOOD LUCK!!!");
        }

        private bool instructions()
        {
            log("DO YOU NEED INSTRUCTIONS  (YES/NO)");
            var ans = Console.ReadLine().ToLower();

            if(ans == "yes" || ans == "y")
            {
                return true;
            }
            else if(ans == "no" || ans == "n")
            {
                return false;
            }

            return false;
        }

        private void game()
        {

        }

        private void log()
        {
            Console.WriteLine("");
        }

        private void log(string text)
        {
            Console.WriteLine(text);
        }
    }
}