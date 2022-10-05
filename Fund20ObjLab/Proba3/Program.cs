using System;

namespace Proba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Telephone telephone = new Telephone("Nokia", "red", 200);

           Telephone telephone2 = new Telephone("Motorola", "blue", 100);

            Telephone telephone3 = new Telephone();

            Telephone.TelephoneVibration();
            
            
            telephone2.TelephonRing();
            telephone.TelephonRing();
            telephone3.TelephonRing();
            
            
        }
    }
}
