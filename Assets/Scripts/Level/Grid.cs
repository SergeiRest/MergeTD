using System;
using System.Collections;
using System.Collections.Generic;
using Infrastucture.Service;
using UnityEngine;

namespace Level.Grid
{
    public class Grid : MonoBehaviour
    {
        [field: SerializeField] public Cell[] Cells { get; private set; }

        private void Awake()
        {
            AllServices.GetService<IGridService>().Init(this);
        }

        public bool HasEmptyCell(out Cell cell)
        {
            foreach (var gridCell in Cells)
            {
                if (gridCell.Tower == null)
                {
                    cell = gridCell;
                    return true;
                }
            }

            cell = null;
            return false;
        }
    }
}