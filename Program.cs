using System;
using game.src.Entities;

namespace game
{

  class Program
   {


        static void Main(string[] args)
        {
             knight arus = new knight("Arus", 23, "Knight");
             Wizard wizard = new Wizard("Jenica", 23, "White Wizzard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
        }

    }
}

