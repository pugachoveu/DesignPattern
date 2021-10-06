using DesignPatterns_Core.AbstractFactory;
using DesignPatterns_Core.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public static class DesignPatterns
    {
        public static void AbstractFactoryExample()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

        }

        public static void BuilderExample()
        {
            VehicleBuilder builder;

            Shop shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }
    }
}
