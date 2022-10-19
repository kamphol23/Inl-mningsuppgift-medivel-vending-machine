using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inlämningsuppgift_medivel_vending_machine
{
    internal class Program
    {
        // skappar en lista för producter.
        public static List<Product> listOfProducts = new List<Product>();
        public static Wallet machineWallet = new Wallet("machineWallet", 0, 0, 0);

        public static Wallet usersWallet = new Wallet("usersWallet", 10, 10, 10);
        static void Main(string[] args)
        {
            machineWallet.linkWallets(usersWallet);

        // Lägger in produkterna i listan.
            listOfProducts.Add(new Apple("Apple", 5, "suprt jucy"));
            listOfProducts.Add(new Apple("asd", 5, "suprt jucy"));
            listOfProducts.Add(new Apple("df", 5, "suprt jucy"));
            Console.Write("what you wanna do? : ");

            Console.WriteLine(machineWallet.totalValue);
            usersWallet.diposit(100);
            Console.WriteLine(machineWallet.totalValue);
            Console.WriteLine(usersWallet.totalValue);

          //  UesrAction(Console.ReadLine());

            //Personen ska kunna se vad för produketer som finns i maskinerna .

            // Personen ska kunna ser vad det kostar.


            // string userInput = Console.ReadLine();



            Console.ReadKey();
        }

        public static void UesrAction( string action)
        {

            switch(action)
            {
                case "Show amount":
                    Console.WriteLine("you curent value {0}", usersWallet.totalValue);
                    break;
                case "Show products":
                    DisplayProducts();
                    break;
                case "wallets":
                    PrintList();
                    break;

            }
        }

        public static void DisplayProducts()
        {
            foreach(Product i in listOfProducts){
                Console.WriteLine("{0}, price {1}", i.name, i.price);
            }
        }

        public static void PrintList()
        {
            foreach (Wallet i in Wallet.wallets)
            {
                Console.WriteLine(i.name);
            }
        }
    }

}

       /* public static async void start(string UserKey)
        {
            Console.WriteLine("du är en riddare som nyss har dödat en mäktikt drake och fått dess guld." );
            await Task.Delay(1750);

            Console.WriteLine("Men att besegra en drake är var ingen dans på rosorna.");
            await Task.Delay(1750);

            Console.WriteLine("Din turstning är skadade eller helt försörda, din mage kurrar och din resepackning är helt slut");
            await Task.Delay(1750);

            Console.Write("Press Y if you to continue : ");

            if (UserKey == "y")
            {
                Console.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
            }
            else
            {
                Console.WriteLine("Bajs på dig");
            }*/

        
       
    
 


