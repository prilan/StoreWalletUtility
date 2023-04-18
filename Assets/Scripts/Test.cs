using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public enum CurrencyType
    {
        Coins,
        Crystals
    }

    internal class Test
    {
        private WalletUtility.WalletUtility walletUtility; // TODO singleton

        public void Main()
        {
            // TODO string by enum in test utility

            walletUtility.CreateCurrency("coins");
            walletUtility.CreateCurrency("crystals");

            walletUtility.IncrementCurrency("coins");
        }
    }
}
