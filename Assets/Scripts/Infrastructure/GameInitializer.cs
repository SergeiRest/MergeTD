using System.Collections;
using System.Collections.Generic;
using Infrastucture.Service;
using Unity.VisualScripting;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    void Awake()
    {
        IContainer container = new Container();
        AllServices.Init(container);
        
        IMoneyService moneyService = new MoneyService();
        container.Register<IMoneyService>(moneyService);
    }
}

public static class AllServices
{
    private static IContainer _container;
    public static void Init(IContainer container)
    {
        _container = container;
    }

    public static TService GetService<TService>() where TService : IService
    {
        return _container.GetService<TService>();
    }
}
