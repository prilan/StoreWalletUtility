using System;
using System.Collections.Generic;
using System.Linq;
using WalletUtility;
using static WalletUtility.Wallet;

namespace TestApp
{
    public enum CurrencyType
    {
        Coins,
        Crystals
    }

    public class Test
    {
        private Wallet walletUtility; // TODO singleton
        

        public void Main()
        {
            // TODO string by enum in test utility

            walletUtility.CreateCurrency("coins");
            walletUtility.CreateCurrency("crystals");

            walletUtility.IncrementCurrency("coins");

            List<Currency> walletCurrencies = walletUtility.Currencies.ToList();
        }
    }
}
