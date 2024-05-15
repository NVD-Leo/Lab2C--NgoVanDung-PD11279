using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Bai2
    {
        public void bai2a()
        {
            var userInfp = new
            {
                id = "2024",
                name = "Faker",
                isplaying = false,
                bag = new
                {
                    skins = 0,
                    cups = 20
                }
            };
            Action<string> log = delegate (string message)
            {
                Console.WriteLine(message);
            };
            log("Id: " + userInfp.id);
            log("Name: " + userInfp.name);
            log("Is Playing: " + userInfp.isplaying);
            log("Bag - Skins: " + userInfp.bag.skins);
            log("Bag - Cups: " + userInfp.bag.cups);
        }
        public void bai2b()
        {
            int y = 10;
            Action<int> AnonymousMethod = delegate ( int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("sum: " +sum);
                Console.WriteLine("sub: " +sub);
            };
            AnonymousMethod(5);
        }
    }
}
