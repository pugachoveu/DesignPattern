using DesignPatterns_Core.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public static class DesignPatterns
    {
        public static void AbstractFactoryExemple()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();  
            
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

        }
    }
}
