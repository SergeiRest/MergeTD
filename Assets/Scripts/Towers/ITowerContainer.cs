using System.Collections;
using System.Collections.Generic;
using Infrastucture.Service;
using UnityEngine;

namespace Scripts.Towers
{
    public interface ITowerContainer : IService
    {
        public AbstractTower[] Towers { get; }
        public AbstractTower GetRandomTower();
    }
}