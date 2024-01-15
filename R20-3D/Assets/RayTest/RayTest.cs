using UnityEngine;
using System;

public class RayTest : MonoBehaviour
{
    Ray ray;
    [SerializeField] private RaycastHit hit;
    [SerializeField] private LayerMask layersToHit;

    void Update()
    {
        // NonMuliShoot();
    }

    // void Shoot()
    // {
    //     ray = new Ray(transform.position, transform.forward);

    //     if(Physics.Raycast(ray, out hit, 999, layersToHit, QueryTriggerInteraction.Ignore))//射線不會碰撞isTrigger的人
    //     {
    //         Debug.Log(hit.collider.gameObject.name);
    //     }
    // }

    // void MuliShoot()
    // {
    //     ray = new Ray(transform.position, transform.forward);

    //     hits = Physics.RaycastAll(ray);
    //     if(hits.Length > 0)
    //     {
    //         Array.Sort(hits, (RaycastHit x, RaycastHit y) => x.distance.CompareTo(y.distance));
    //         for(int i = 0; i < hits.Length; i++)
    //         {
    //             Debug.Log(hits[i].collider.gameObject.name);
    //         }
    //     }
    // }
    // void NonMuliShoot()
    // {
    //     ray = new Ray(transform.position, transform.forward);

    //     int numHits = Physics.RaycastNonAlloc(ray, hits);
    //     if(numHits > 0)
    //     {
    //         for(int i = 0; i < numHits; i++)
    //         {
    //             Debug.Log(hits[i].collider.gameObject.name);
    //         }
    //     }
    // }
}
