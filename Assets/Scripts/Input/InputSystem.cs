using Infrastucture;
using Infrastucture.Service;
using Scripts.Towers;
using UnityEngine;

namespace Logic.InputSystem
{
    public class InputSystem : MonoBehaviour
    {
        [SerializeField] private float distance;

        private IMovingService movingService = AllServices.GetService<IMovingService>();

        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastCheck();
            }
            else if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 pos = ray.origin;
                pos.y += distance;
                Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit, distance);
                movingService.Move(hit.point);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                movingService.TurnBack();
            }
        }

        private void RaycastCheck()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, distance))
            {
                if (hit.collider.TryGetComponent(out IGameEntity draggable))
                {
                    movingService.Select(draggable);
                }
            }
        }
    }
}