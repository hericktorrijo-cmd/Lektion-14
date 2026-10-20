using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Skapa_en_egen_undantagsklass
{
    internal class SaldoSaknasException: Exception
    {
        public SaldoSaknasException(string error) : base(error)
        {
            
        }
    }
}
