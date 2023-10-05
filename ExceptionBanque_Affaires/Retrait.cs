using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBanque_Affaires
{
    public class Retrait : Transaction
    {
        public Retrait(decimal montant) : base(montant) { }

        public override decimal effectuer() { return -_montant; }
    }
}
