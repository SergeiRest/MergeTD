using UnityEngine;
using Scripts.Towers;

namespace Level.Grid
{
    public class Cell : MonoBehaviour
    {
        [SerializeField] private Transform pointToBuild;

        private AbstractTower tower = null;

        public AbstractTower Tower => tower;

        public void SetChild(AbstractTower tower)
        {
            this.tower = tower;
            tower.transform.SetParent(transform);
            tower.transform.localPosition = Vector3.zero;
        }
    }
}