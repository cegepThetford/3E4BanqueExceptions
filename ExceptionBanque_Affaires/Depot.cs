using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBanque_Affaires
{
    public class Depot : Transaction
    {
        public Depot(decimal montant) : base(montant) { }

        public override decimal effectuer() { return _montant; }
    }
}
