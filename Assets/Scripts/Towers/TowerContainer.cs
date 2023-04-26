using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Towers
{
    public class TowerContainer : ITowerContainer
    {
        public AbstractTower[] Towers { get; }

        public TowerContainer()
        {
            Towers = Resources.LoadAll<AbstractTower>(AssetsPath.Towers);
        }
        
        public AbstractTower GetRandomTower()
        {
            return Towers.GetRandomValue();
        }
    }
}
