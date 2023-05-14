using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    // Start is called before the first frame update
    void OnEnable()
    {
        BallSpawner.BallSpawned += Kill;
    }

    void Kill()
    {
        Debug.Log("Kill");
    }
}   

