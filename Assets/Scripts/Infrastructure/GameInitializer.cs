using Infrastucture.Service;
using Scripts.Towers;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInitializer : MonoBehaviour
{
    private void Awake()
    {
        IContainer container = new Container();
        AllServices.Init(container);
        
        IMoneyService moneyService = new MoneyService();
        IGridService gridService = new GridService();
        ITowerContainer towerContainer = new TowerContainer();
        
        container.Register<IMoneyService>(moneyService);
        container.Register<IGridService>(gridService);
        container.Register<ITowerContainer>(towerContainer);
        SceneManager.LoadScene(1);
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
