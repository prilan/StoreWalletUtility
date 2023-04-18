using UnityEditor;
using UnityEngine;

namespace WalletUtility
{
    public interface ICurrency
    {
        void SetValue(int currencyValue);
    }
}