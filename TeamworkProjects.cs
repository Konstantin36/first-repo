using System;
using System.Collections.Generic;
using System.Linq;

class TeamworkProjects
{
    static void Main()
    {
        List<Team> teamList = Team.ReadListOfTeams();
         List<Team> teamDisbandList = teamList.Where(x => x.MembersList.Count == 0).OrderBy(n => n.Name).ToList();

        teamList = teamList.Where(x => x.MembersList.Count > 0).
            OrderByDescending(x => x.MembersList.Count).ThenBy(x => x.Name).ToList();

        PrintResult(teamList, teamDisbandList);
    }

    private static void PrintResult(List<Team> teamList, List<Team> teamDisbandList)
    {
        foreach (var team in teamList)
        {
            string teamName = team.Name;
            string creatorName = team.CreatorName;
            List<string> membersList = team.MembersList.OrderBy(x => x).ToList();

            Console.WriteLine(teamName);
            Console.WriteLine($"- {creatorName}");

            foreach (var member in membersList)
            {
                Console.WriteLine($"-- {member}");
            }
        }

        Console.WriteLine("Teams to disband:");
        

        foreach (var teamDisband in teamDisbandList)
        {
            string teamName = teamDisband.Name;
            Console.WriteLine(teamName);
        }
    }
}

class Team
{
    public string CreatorName { get; set; }
    public string Name { get; set; }
    public List<string> MembersList { get; set; }

    private static Team ReadTeam(string creatorName, string teamName)
    {
        Team team = new Team()
        {
            CreatorName = creatorName,
            Name = teamName,
            MembersList = new List<string>()
        };
        return team;
    }

    public static List<Team> ReadListOfTeams()
    {
        List<Team> teamsList = new List<Team>();

        int n = int.Parse(Console.ReadLine());
        string input = string.Empty;

        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();

            //int creatorNameLength = input.IndexOf("-");
            //string creatorName = input.Substring(0, creatorNameLength);
            //string teamName = input.Substring(creatorNameLength + 1);

            string creatorName = input.Split('-')[0];
            string teamName = input.Split('-')[1];

            bool isTeamExist = teamsList.Any(x => x.Name == teamName);
            bool isCreatorNameExist = teamsList.Any(x => x.CreatorName == creatorName);

            if (isTeamExist)
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (isCreatorNameExist)
            {
                Console.WriteLine($"{creatorName} cannot create another team!");
            }
            else
            {
                teamsList.Add(ReadTeam(creatorName, teamName));
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }
        }

        input = Console.ReadLine();
        while (!input.Equals("end of assignment"))
        {

            //int personNameLength = input.IndexOf("->");
            //string personName = input.Substring(0, personNameLength);
            //string teamName = input.Substring(personNameLength + 2);

            string personName = input.Split(new string[] { "->" },
                StringSplitOptions.RemoveEmptyEntries)[0];
            string teamName = input.Split(new string[] { "->" },
                StringSplitOptions.RemoveEmptyEntries)[1];

            bool isTeamExist = teamsList.Any(x => x.Name == teamName);
            bool isPersonCreatorOfTeam = teamsList.Any(x => x.CreatorName == personName);
            bool isPersonMemberOfTeam = teamsList.Any(x => x.MembersList.Contains(personName));

            int teamIndex = GetTeamIndex(teamsList, teamName);

            if (!isTeamExist)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }
            else if (isPersonMemberOfTeam || isPersonCreatorOfTeam)
            {
                Console.WriteLine($"Member {personName} cannot join team {teamName}!");
            }
            else
            {           
                teamIndex = GetTeamIndex(teamsList, teamName);
                teamsList[teamIndex].MembersList.Add(personName);
            }

            input = Console.ReadLine();
        }

        return teamsList;
    }

    private static int GetTeamIndex(List<Team> teamsList, string teamName)
    {
        int teamIndex = 0;

        for (int i = 0; i < teamsList.Count; i++)
        {
            if (teamsList[i].Name.Equals(teamName))
            {
                teamIndex = i;
                break;
            }
        }
        return teamIndex;
    }
}