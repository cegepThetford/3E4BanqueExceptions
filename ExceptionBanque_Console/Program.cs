using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionBanque_Affaires;

namespace ExceptionBanque_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            demo1();
            demo2();
        }

        public static void demo1()
        {
            decimal montantTrx = 100.0m;
            Compte c = new Compte(12345, "Marco Guay", 420);
            decimal s = c.calculerSolde();
            if(s > montantTrx)
            {
                Transaction t = new Retrait(montantTrx);
                c.ajouterTransaction(t);
            }
        }
        public static void demo2()
        {
            decimal montantTrx = 100.0m;
            Compte c = new Compte(12345, "Marco Guay", 420);
            Transaction t = new Retrait(montantTrx);
            try {
                c.ajouterTransaction(t);
            } catch(Exception e) {
                // que faire si le compte refuse l'ajout de cette transaction???
                // (le faire ici)
            }
        }
    }
}
