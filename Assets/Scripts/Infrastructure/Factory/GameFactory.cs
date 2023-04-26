using System.Linq;
using Infrastucture.Service;
using Level.Grid;
using Scripts.Towers;
using UnityEngine;

public static class GameFactory
{
    public static void BuildRandomTower(Cell cell)
    {
        var towerContainer = AllServices.GetService<ITowerContainer>();
        AbstractTower tower = towerContainer.GetRandomTower();
        
        var spawnedTower = Object.Instantiate(tower);
        cell.SetChild(spawnedTower);
    }

    public static void BuildSelectedTower(Cell cell, AbstractTower tower)
    {
        var towerContainer = AllServices.GetService<ITowerContainer>();
        var selected = towerContainer.Towers.First(govno => govno.GetType() == tower.GetType());

        var spawnedTower = Object.Instantiate(tower);
        cell.SetChild(spawnedTower);
    }

    public static void CreateSelectTowerButton(Transform parent)
    {
        SelectTowerButton prefab = Resources.Load<SelectTowerButton>(AssetsPath.SelectTowerButton);
        AbstractTower[] towers = AllServices.GetService<ITowerContainer>().Towers;
        foreach (var tower in towers)
        {
            var selected = tower.GetType();
            var spawned = Object.Instantiate(prefab);
            spawned.Init(tower);
            spawned.transform.SetParent(parent);
        }
    }
}
