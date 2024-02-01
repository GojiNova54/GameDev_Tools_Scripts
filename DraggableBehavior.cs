using UnityEngine;
using UnityEngine.Events;

public class DraggableBehavior : MonoBehaviour
{
    private float zCoordinate;
    public UnityEvent startDragEvent, endDragEvent;

    void OnMouseDown()
    {
        zCoordinate = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        startDragEvent.Invoke();
        
    }

    void OnMouseDrag()
    {
        Vector3 posMove = GetMouseWorldPos();
        transform.position = new Vector3(posMove.x, posMove.y, transform.position.z);
    }
    
    void OnMouseUp()
    {
        endDragEvent.Invoke();
    }

    private Vector3 GetMouseWorldPos()
    {
        
        Vector3 mousePoint = Input.mousePosition;

        
        mousePoint.z = zCoordinate;

        
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}











