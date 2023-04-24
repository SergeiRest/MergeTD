using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyService : IMoneyService
{
    public int MoneyCount => money;

    private int money = 100;

    public void AddMoney(int value)
    {
        money += value;
        Debug.Log("Add " + money);

    }
}
