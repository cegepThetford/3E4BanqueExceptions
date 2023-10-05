using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBanque_Affaires
{
    public class Compte
    {
        private int _numero;
        private string _detenteur;
        private int _nip;
        private List<Transaction> _transactions;

        public int Numero { get { return _numero; } }
        public string Detenteur { get { return _detenteur; } }
        public int Nip { get { return _nip; } set { _nip = value; } }
        public List<Transaction> Transactions { get { return _transactions; } set { _transactions = value; } }

        public Compte(int idCompte, string detenteur, int nip)
        {
            _numero = idCompte; 
            _detenteur = detenteur; 
            _nip = nip;
            _transactions = new List<Transaction>();
        }
        public void ajouterTransaction(Transaction uneTrx)
        {
            _transactions.Add(uneTrx);
        }
        public decimal calculerSolde()
        {
            decimal total = 0.0m;
            foreach(Transaction trx in _transactions)
                total += trx.effectuer();
            return total;
        }
    }
}

