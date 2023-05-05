using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Infrastucture.Service
{
    public interface IMovingService : IService
    {
        public void Select(IGameEntity entity);
        public void Move(Vector3 position);
        public void TurnBack();
    }
}