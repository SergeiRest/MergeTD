using System;
using System.Collections;
using System.Collections.Generic;
using Infrastucture.Service;
using Level.Grid;
using Scripts.Towers;
using UnityEngine;
using UnityEngine.UI;

public class SelectTowerButton : MonoBehaviour
{
    [SerializeField] private Button buyButton;
    
    public void Init(AbstractTower tower)
    {
        buyButton.onClick.AddListener(() => BuyTower(tower));

        void BuyTower(AbstractTower tower)
        {
            AllServices.GetService<IGridService>().TryBuildSelectedTower(out Cell cell, tower);
        }
    }
}
