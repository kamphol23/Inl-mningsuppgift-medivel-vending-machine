using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_medivel_vending_machine
{
    internal class Wallet
    {
        public string name;

        //Total amount of the diffrent coins
        public int amountsOFOnes;
        public int amountOfFives;
        public int amontOfTens;

        //All the money combined
        public int totalValue;

        //Lista för alla obj skapad av wallet klassen
        public static List<Wallet> wallets = new List<Wallet>();

        public Wallet linkedWallet;


        public Wallet(string name, int amountsOFOnes, int amountOfFives, int amontOfTens)
        {   
            
            this.name = name;
            this.amountsOFOnes = amountsOFOnes;
            this.amountOfFives = amountOfFives;
            this.amontOfTens = amontOfTens;
            this.totalValue = amountsOFOnes + amountOfFives * 5 + amontOfTens * 10;

            this.linkedWallet = null;


        }

        public void linkWallets(Wallet linkedWallet)
        {
            this.linkedWallet = linkedWallet;

            linkedWallet.linkedWallet = this;
        }

        public void diposit(int amount)
        {
            linkedWallet.totalValue = linkedWallet.totalValue + amount;
            this.totalValue = this.totalValue - amount;
        }
    }  
}
