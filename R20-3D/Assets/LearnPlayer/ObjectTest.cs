using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectTest : MonoBehaviour
{
    NewObject newObject;
    public NewObject newObject2;

    void Start()
    {
        newObject = (NewObject)ScriptableObject.CreateInstance(typeof(NewObject));
        Debug.Log(newObject.atk);
        Debug.Log(newObject2.objectName);
    }

  
}
