using UnityEngine;

public class GizmoShower : MonoBehaviour
{
    [Range(0,10)] public float radius = 1;
    public Lerper _lerper;
    private void Start() 
    {
        _lerper._scaleLevel++;
    }

    private void OnDrawGizmos() 
    {
        Gizmos.DrawSphere(transform.position, radius);
        Gizmos.color = Color.yellow;
        for (int i = 0; i < 100; i++)
        {
            Gizmos.color = Random.ColorHSV();
            Gizmos.DrawSphere(Random.insideUnitSphere * 12, radius);
        }
    }
}

