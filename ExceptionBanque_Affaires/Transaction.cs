using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBanque_Affaires
{
    public abstract class Transaction
    {
        protected decimal _montant;
        protected DateTime _dateHeure;
        public decimal Montant { get { return _montant; } }
        public DateTime DateHeure { get { return _dateHeure; } }
        public Transaction(decimal montant)
        {
            _montant = montant;
            _dateHeure = new DateTime();
        }
        public abstract decimal effectuer();
    }
}