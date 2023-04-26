using System;
using Infrastucture.Service;
using Level.Grid;
using UnityEngine;

public class BuyRandomTowerButton : MonoBehaviour
{
    public void Buy()
    {
        var moneyService = AllServices.GetService<IMoneyService>();
        var gridService = AllServices.GetService<IGridService>();
        gridService.TryBuild(out Cell cell);
    }
}
