using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<teamMember> myTeam = new List<teamMember>();
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("How difficult would you like the bank to be?");
            int bankDifficulty = int.Parse(Console.ReadLine());
            
            //add a loop that breaks when no name is input
            for (int i = 0; i == i; i++){
            Console.WriteLine($"Enter team member number {i + 1}'s name?");
            string name = Console.ReadLine();
            if (name == "") {
                break;
            }
            Console.WriteLine("What is your skill level?");
            int skillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your courage factor from 0.0 to 2.0?");
            double courageFactor = double.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {name}. Your skill level is {skillLevel} and your courage factor is {courageFactor}.");
            Console.WriteLine();
            

            //add member input to make a team member in our myTeam list
            var newMember = new teamMember();
            newMember.createTeamMember(name, skillLevel, courageFactor);
            // Console.WriteLine(newMember.name);
            
            //add the team member to the list
            myTeam.Add(newMember);
            
            }
            //Ask how many trials the team would like to try
            Console.WriteLine($"Congratulations on building your team! There are {myTeam.Count} members on your team. How many trail runs would you like to run?");
            
            int trials = int.Parse(Console.ReadLine());

             //Add up skill levels from all members in the list
            int teamSkillLevel = 0;
            foreach(teamMember member in myTeam){
                
                teamSkillLevel += member.skillLevel;
            };

            //Loop through the number of trials making a different value for the bank difficulty each run through
            var failedTrials = 0;
            var successfulTrials = 0;

            for (int i = 0; i < trials; i++){
            
            int luckFactor = new Random().Next(-10, 10);
            int bankTotalDifficulty = bankDifficulty + luckFactor;
            
           
            //Display the team's skill level and the bank's difficulty level  
            Console.WriteLine($"Attempt #{i +1}:");         
            Console.WriteLine($"The team's skill level is {teamSkillLevel}");
            Console.WriteLine($"The bank's difficulty level is {bankTotalDifficulty}");

            //Tell whether the team will be successfull or not
            if (teamSkillLevel > bankTotalDifficulty)
            {
                Console.WriteLine("Congratulations. Your team will succeed!");
                successfulTrials += 1;

            } else {
                Console.WriteLine("You better go back to the drawing board :(");
                failedTrials += 1;
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            
            };
            
            Console.WriteLine($"Your team suceeded {successfulTrials} times.");
            Console.WriteLine($"Your team failed {failedTrials} times.");
            
            
            
            //to display the team members information use loop below
            // foreach (teamMember teamMember in myTeam)
            // {
            //     Console.WriteLine(teamMember.name);
            //     Console.WriteLine(teamMember.skillLevel);
            //     Console.WriteLine(teamMember.courageFactor);
            // }
            
            

            

            



        }
    }
}
