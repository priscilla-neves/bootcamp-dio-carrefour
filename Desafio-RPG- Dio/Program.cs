using System;
using POO.src.entities;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight ("Arus", 23, "Knight", 749, 72);
            Wizard wizard = new Wizard ("Jennica", 23, "White Wizard", 601, 482);
            Ninja wedge = new Ninja ( "Wedge", 23, "Ninja", 574, 89 );
            BlackWizard topapa = new BlackWizard ("Topapa", 23, "BlackWizard", 385, 641);

            Console.WriteLine (wizard.Attack(1));
            Console.WriteLine (wizard.Attack(7));
            
        }
    }
}
