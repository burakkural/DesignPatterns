using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Abstract_Factory
{
    public interface IFootballFactory
    {
        ITeam CreateTeam();
        IPlayer CreatePlayer();
    }
}
