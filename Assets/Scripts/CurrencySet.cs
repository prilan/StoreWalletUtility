﻿using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using WalletUtility;

namespace Assets.Scripts
{
    public class CurrencySet
    {
        private HashSet<ICurrency> currencySet;

        public void AddCurrency(ICurrency currency)
        {
            currencySet.Add(currency);
        }
    }
}