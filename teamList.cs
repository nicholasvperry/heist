using System;
using System.Collections.Generic;

namespace heist
{

    public class teamList
    {
        List<teamMember> myTeam {get; set;} = new List<teamMember>();

        public void addMember(teamMember person)
        {
            myTeam.Add(person);
        }
        
    }
}