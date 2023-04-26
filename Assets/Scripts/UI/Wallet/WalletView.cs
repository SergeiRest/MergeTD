using UnityEngine;
using UnityEngine.UI;

namespace Scripts.UI.Wallet
{
    public class WalletView : UIMenu
    {
        [SerializeField] private Text money;

        public void SetMoneyCount(int value)
        {
            money.text = value.ToString();
        }
    }
}