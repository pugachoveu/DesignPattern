using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Core.AbstractFactory
{
    public static class AbstractFactory
    {
        public static void Execute()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();
            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

        }
    }
}
