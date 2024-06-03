using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{

    abstract class SpaceSation
    {
        public abstract void FireLaser();
    }

    class DeathStar : SpaceSation
    {

        public override void FireLaser() {
            Console.WriteLine("Phew phew");
            }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DeathStar c = new DeathStar();
            c.FireLaser();
        }
    }
}
