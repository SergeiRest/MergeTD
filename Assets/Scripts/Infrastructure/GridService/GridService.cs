using System.Collections;
using System.Collections.Generic;
using Level.Grid;
using Scripts.Towers;
using UnityEngine;

namespace Infrastucture.Service
{
    public class GridService : IGridService
    {
        private Level.Grid.Grid grid;
        
        public void Init(Level.Grid.Grid grid)
        {
            this.grid = grid;
        }

        public void TryBuild(out Cell cell)
        {
            if (grid.HasEmptyCell(out cell))
            {
                GameFactory.BuildRandomTower(cell);
            }
        }

        public void TryBuildSelectedTower(out Cell cell, AbstractTower tower)
        {
            if (grid.HasEmptyCell(out cell))
            {
                GameFactory.BuildSelectedTower(cell, tower);
            }
        }
    }
}