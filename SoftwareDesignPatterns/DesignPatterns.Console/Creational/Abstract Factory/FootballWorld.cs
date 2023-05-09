using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Abstract_Factory
{
    public class FootballWorld
    {
        private readonly ITeam _team;
        private readonly IPlayer _player;
        public FootballWorld(IFootballFactory factory)
        {
            _team = factory.CreateTeam();
            _player = factory.CreatePlayer();
        }

        public string GetFootballTeamColor()
        {
            return _team.GetTeamColor();
        }

        public string GetTopScorer()
        {
            return _player.GetTopScorer();
        }
    }
}
