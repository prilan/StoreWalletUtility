using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace WalletUtility
{
    public class Wallet : AbstractSingleton<Wallet>
    {
        private CurrencySet currencySet = new CurrencySet();

        private List<Currency> currencyList => currencySet.Currencies.Values.ToList();

        public ReadOnlyCollection<Currency> Currencies => new ReadOnlyCollection<Currency>(currencyList);

        public void CreateCurrency(string currencyName)
        {
            Currency currency = new Currency(currencyName);
            currencySet.AddCurrency(currency);
        }

        public void IncrementCurrency(string curencyName)
        {
            if (currencySet.HasCurrency(curencyName))
            {
                Currency currency = currencySet.GetCurrency(curencyName);
                currency.IncrementValue();
            }
        }

        public void ZeroCurrency(string curencyName)
        {
            if (currencySet.HasCurrency(curencyName))
            {
                Currency currency = currencySet.GetCurrency(curencyName);
                currency.SetValue(0);
            }
        }

        public Currency GetCurrency(string curencyName)
        {
            if (currencySet.HasCurrency(curencyName))
            {
                Currency currency = currencySet.GetCurrency(curencyName);
                return currency;
            }

            return null;
        }

        private class CurrencySet
        {
            private Dictionary<string, Currency> currencyDictionary = new Dictionary<string, Currency>();

            public Dictionary<string, Currency> Currencies => currencyDictionary;

            public void AddCurrency(Currency currency)
            {
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
