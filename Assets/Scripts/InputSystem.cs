using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    [SerializeField] private Transform MouseVisual;
    [SerializeField] private LayerMask GroundLayerMask;

    private void Update()
    {
        MouseVisual.position = GetPosition();
    }

    public Vector3 GetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, GroundLayerMask);
        return hit.point;
    }
}
