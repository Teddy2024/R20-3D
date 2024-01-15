using UnityEngine;

public class PlaneRay : MonoBehaviour
{
    Plane plane = new Plane(Vector3.down, 0);

    private void Update() 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(plane.Raycast(ray, out float distance))
        {
            transform.position = ray.GetPoint(distance);
        }
    }
}
