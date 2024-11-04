using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagement : MonoBehaviour
{
    [SerializeField] Transform _wathToMove;
    private void Update()
    {
        ManageMove();
    }

   private void ManageMove()
    {
        if (Input.touchCount <= 0) return;
        
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        float halfWidth = Camera.main.orthographicSize * Camera.main.aspect;
        float clampedX = Mathf.Clamp(worldPos.x, -halfWidth, halfWidth);

        _wathToMove.position = new Vector3(clampedX, _wathToMove.position.y, mousePos.z);
    }

    private Queue<GameObject> objectPool;
}