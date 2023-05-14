using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnProperty : MonoBehaviour
{
   private int teddyCount;

   public int TeddyCount
   {
        get
        {
            return teddyCount + 1;
            //A += 1 ，A = A+1
            //B = A+1
        }
        set
        {
            teddyCount = value += 10;
        }
   }

   private void Start() 
   {
    //TeddyCount = 1000;
    Debug.Log(teddyCount);
    Debug.Log(TeddyCount);
    Debug.Log(teddyCount);
    Debug.Log(TeddyCount);
    Debug.Log(teddyCount);
   }
}
