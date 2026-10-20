using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Skapa_en_egen_undantagsklass
{
    internal class Bankkonto
    {

        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            
        }

        public Bankkonto()
        {
            saldo = 50;
        }
        public void Uttag(double belopp)
        {
            if(belopp >  saldo)
            {
                throw new SaldoSaknasException("Du saknar saldo för detta utttag");
            }
            else
            {
                saldo -= belopp;
            }
        }
    }
}
