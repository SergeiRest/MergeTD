using System;

namespace Infrastucture.Service
{
    public interface IMoneyService : IService
    {
        public int MoneyCount { get; }
        public event Action<int> MoneyCountChanged;

        public void AddMoney(int value);
        public void SendEvent();
    }
}