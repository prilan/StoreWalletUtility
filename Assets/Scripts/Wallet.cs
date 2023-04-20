using System;
using System.Collections.Generic;

namespace WalletUtility
{
    public class Wallet : AbstractSingleton<Wallet>
    {
        private CurrencySet currencySet;

        public void CreateCurrency(string currencyName)
        {
            Currency currency = new Currency(currencyName);
            currencySet.AddCurrency(currency);
        }

        public bool IncrementCurrency(string curencyName)
        {
            if (currencySet.HasCurrency(curencyName))
            {
                Currency currency = currencySet.GetCurrency(curencyName);
                currency.IncrementValue();

                return true;
            }

            return false;
        }

        private class CurrencySet
        {
            private HashSet<ICurrency> currencySet = new HashSet<ICurrency>();
            private Dictionary<string, Currency> currencyDictionary = new Dictionary<string, Currency>();

            public void AddCurrency(Currency currency)
            {
                currencySet.Add(currency);
                currencyDictionary[currency.CurrencyName] = currency;
            }

            public bool HasCurrency(string currencyName)
            {
                return currencyDictionary.ContainsKey(currencyName);
            }

            public Currency GetCurrency(string currencyName)
            {
                return currencyDictionary[currencyName];
            }
        }
    }
}
