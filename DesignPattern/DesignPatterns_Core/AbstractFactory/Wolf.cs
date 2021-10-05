using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Core.AbstractFactory
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
        }
    }
}
