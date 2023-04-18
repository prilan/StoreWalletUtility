using System;
using Unity.VisualScripting;

namespace WalletUtility
{
    public class WalletUtility
    {
        public CurrencySet CurrencySet;

        public void CreateCurrency(string currencyName)
        {
            Currency currency = new Currency(currencyName);
            CurrencySet.AddCurrency(currency);
        }

        public bool IncrementCurrency(string curencyName)
        {
            if (CurrencySet.HasCurrency(curencyName))
            {
                Currency currency = CurrencySet.GetCurrency(curencyName);
                currency.IncrementValue();

                return true;
            }

            return false;
        }
    }
}
