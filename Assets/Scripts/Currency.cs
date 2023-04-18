using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WalletUtility
{
    public class Currency : ICurrency
    {
        public string CurrencyName;
        public int CurrencyValue { get; private set; }

        Currency(string currencyName, int currencyValue = 0)
        {
            CurrencyName = currencyName;
            CurrencyValue = currencyValue;
        }

        public void SetValue(int currencyValue)
        {
            
        }
    }
}
