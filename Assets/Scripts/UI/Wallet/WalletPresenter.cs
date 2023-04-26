using System;
using System.Collections;
using System.Collections.Generic;
using Infrastucture.Service;
using UnityEngine;

namespace Scripts.UI.Wallet
{
    public class WalletPresenter : MonoBehaviour
    {
        [SerializeField] private WalletView walletView;
        private void Awake()
        {
            var moneyService = AllServices.GetService<IMoneyService>();
            moneyService.MoneyCountChanged += walletView.SetMoneyCount;
            moneyService.SendEvent();
        }
    }
}