using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoneyService : IService
{
    public int MoneyCount { get; }
    public void AddMoney(int value);
}
