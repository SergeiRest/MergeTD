using Infrastucture;
using UnityEngine;

namespace Scripts.Towers
{
    public abstract class AbstractTower : MonoBehaviour, IGameEntity
    {
        [SerializeField] private int level = 1;
        public Transform Transform => transform;
    }
}