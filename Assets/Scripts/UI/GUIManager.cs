using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    private static GUIManager instance = null;
    public static GUIManager Instance => instance;
    
    [SerializeField] private List<UIMenu> menus;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(this);
        foreach (var menu in menus)
        {
            menu.Init();
        }
    }

    public TMenu GetUI<TMenu>() where TMenu : UIMenu
    {
        var menu = menus.FirstOrDefault(i => i.GetType() == typeof(TMenu)); 
        return (TMenu)menu;
    }

    public void Show<TMenu>() where TMenu : UIMenu
    {
        var menu = menus.FirstOrDefault(m => m.GetType() == typeof(TMenu));
        menu.gameObject.SetActive(true);
    }

    public void Hide<TMenu>() where TMenu : UIMenu
    {
        var menu = menus.FirstOrDefault(m => m.GetType() == typeof(TMenu));
        menu.gameObject.SetActive(false);
    }
}

public class UIMenu : MonoBehaviour
{
    public virtual void Init()
    {
        
    }
}