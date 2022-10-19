using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_medivel_vending_machine
{
    internal class Apple : Product, IProduct
    {
        public Apple(string name, int price, string description) : base(name, price, description)
        {


        }

        public void Buy(int BuyersMoney)
        {
            if (BuyersMoney >= price)
            {
                Console.WriteLine("you bouath a apple");
            }
            else
            {
                Console.WriteLine("not enougth money");
            }
        }

        public void Eat()
        {
            Console.WriteLine("You took a bit of the apple, it was yummy");
        }

        public void Peel()
        {
            Console.WriteLine("You grab your knife and start to peel the skin of the apple");
        }

        public void Description() { }
        public void Wear() { }
        public void Use() { }


    }

}
