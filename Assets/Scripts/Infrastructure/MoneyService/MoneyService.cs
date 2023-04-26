using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Infrastucture.Service
{
    public class MoneyService : IMoneyService
    {
        private int money = 100;

        public int MoneyCount => money;
        public event Action<int> MoneyCountChanged;

        public void AddMoney(int value)
        {
            money += value;
        }

        public void SendEvent()
        {
            MoneyCountChanged?.Invoke(MoneyCount);
        }

    }
}