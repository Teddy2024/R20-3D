using UnityEngine;

public class ScreenRay : MonoBehaviour
{
    private void Start() 
    {
    }
    void Update()
    {
        // Debug.DrawRay()
    }

    // void ScreenRayPork()
    // {
    //     if(Input.GetMouseButtonDown(0))
    //     {
    //         Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

    //         if(Physics.Raycast(cameraRay, out RaycastHit hit))
    //         {
    //             Debug.Log(hit.collider.gameObject.name);
    //         }
    //     }
    // }

    // void ScreenMiddleRay()
    // {
    //     Ray cameraRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
    //     if(Physics.Raycast(cameraRay, out RaycastHit hit))
    //     {
    //         Debug.Log(hit.collider.gameObject.name);
    //     }
    // }
}
