using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Level.Grid;
using UnityEngine;

namespace Infrastucture.Service
{
    public class MovingService : IMovingService
    {
        private IGameEntity selected;
        private Vector3 defaultPosition;
        private float speed = 10;
        
        public void Select(IGameEntity entity)
        {
            defaultPosition = entity.Transform.position;
            selected = entity;
        }

        public void Move(Vector3 position)
        {
            if(selected == null)
                return;
            Vector3 movePosition = Vector3.Lerp(selected.Transform.position, position, speed * Time.deltaTime);
            movePosition.y = defaultPosition.y;
            selected.Transform.position = movePosition;
        }

        public void TurnBack()
        {
            if(selected == null)
                return;
            
            TryPlace();
            selected = null;
        }

        private void TryPlace()
        {
            Cell cell = FindNewParent();
            if (cell != null)
            {
                cell.SetChild(selected);
            }
            else
            {
                selected.Transform.position = defaultPosition;
            }
        }

        private Cell FindNewParent()
        {
            var gridService = AllServices.GetService<IGridService>();
            Cell[] cells = gridService.GetGrid().Cells;
            Cell currentCell = cells.FirstOrDefault(cell => cell.Tower == selected);
            Cell newParent;
            List<Cell> relevantCells = new List<Cell>();

            foreach (var cell in cells)
            {
                var distance = (selected.Transform.position - cell.transform.position).sqrMagnitude;
                if(distance <= 1 && cell != currentCell)
                    relevantCells.Add(cell);
            }

            if (relevantCells.Count == 0)
                return null;
            else
            {
                newParent = relevantCells[0];
                if(relevantCells.Count > 1)
                {
                    for (int i = 1; i < cells.Length; i++)
                    {
                        if ((selected.Transform.position - cells[i].transform.position).sqrMagnitude <
                            (selected.Transform.position - newParent.transform.position).sqrMagnitude)
                        {
                            newParent = cells[i];
                        }
                    }
                }
                
                currentCell.Clear();
                relevantCells.Clear();
                return newParent;
            }
        }
    }
}