using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using WalletUtility;

namespace WalletUtility
{
    public class CurrencySet
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