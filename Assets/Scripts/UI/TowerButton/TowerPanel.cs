using System.Collections;
using System.Collections.Generic;
using Scripts.Towers;
using UnityEngine;

public class TowerPanel : UIMenu
{
    public override void Init()
    {
        base.Init();
        GameFactory.CreateSelectTowerButton(transform);
    }

    public void Show()
    {
        GUIManager.Instance.Show<TowerPanel>();
    }

    public void Hide()
    {
        GUIManager.Instance.Hide<TowerPanel>();
    }
}
