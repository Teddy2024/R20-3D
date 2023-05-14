using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallSpawner : MonoBehaviour
{
    
    public static event Action BallSpawned;
    public Action BallSpawned001;
    // Start is called before the first frame update
    void Start()
    {
        //BallSpawned = Teddy;
        BallSpawned?.Invoke();
        BallSpawned001?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Teddy()
    {
        Debug.Log("Teddy");
    }

    
}
