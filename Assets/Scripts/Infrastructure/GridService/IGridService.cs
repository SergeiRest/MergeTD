using System.Collections;
using System.Collections.Generic;
using Level.Grid;
using Scripts.Towers;
using UnityEngine;

namespace Infrastucture.Service
{
    public interface IGridService : IService
    {
        public void Init(Level.Grid.Grid grid);
        public void TryBuild(out Cell cell);
        public void TryBuildSelectedTower(out Cell cell, AbstractTower tower);
        public Level.Grid.Grid GetGrid();
    }
}