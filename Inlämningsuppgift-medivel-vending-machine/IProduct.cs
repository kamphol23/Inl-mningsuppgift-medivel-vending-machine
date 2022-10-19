using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_medivel_vending_machine
{
    interface IProduct
    {    
    // Köpa
    void Buy(int x);

    //  Äta
    void Eat();

    // Skala
    void Peel();

    // Info om Produkten
    void Description();

    // Ha på sig 
    void Wear();

    // Använd 
    void Use();

    


}
}
