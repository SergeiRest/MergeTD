using System;
using Infrastucture;
using UnityEngine;
using Scripts.Towers;

namespace Level.Grid
{
    public class Cell : MonoBehaviour
    {
        [SerializeField] private Transform pointToBuild;

        private IGameEntity tower;

        public IGameEntity Tower => tower;

        public void SetChild(IGameEntity tower)
        {
            this.tower = tower;
            tower.Transform.SetParent(transform);
            tower.Transform.localPosition = Vector3.zero;
        }

        public void Clear()
        {
            tower = null;
        }
    }
}