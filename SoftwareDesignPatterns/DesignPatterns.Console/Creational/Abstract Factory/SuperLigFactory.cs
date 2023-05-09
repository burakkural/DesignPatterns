using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Abstract_Factory
{
    public class SuperLigFactory : IFootballFactory
    {
        public IPlayer CreatePlayer()
        {
            return new SuperLigPlayer();
        }

        public ITeam CreateTeam()
        {
            return new Galatasaray();
        }
    }

    public class Galatasaray : ITeam
    {
        public string GetTeamColor()
        {
            return "Yellow and Red";
        }
    }

    public class SuperLigPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Mario Icardi";
        }
    }
}
