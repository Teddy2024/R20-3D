using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestEvents2 : MonoBehaviour
{
    void Start()
    {
        //EventHandler客制化
        TestEvents testEvents = GetComponent<TestEvents>();
        testEvents.onSpacePressed += TestOnSpacePressed;
 
    }

    void Update()
    {
        //TestEvents.Change();
        //調用Static
    }


    //EventHandler增加的函數
    void TestOnSpacePressed(object sender, TestEvents.onSpacePressedEventArgs e)
    {
        Debug.Log("It works!!!" + e.localEventNumber);
        // TestEvents testEvents = GetComponent<TestEvents>();
        // testEvents.onSpacePressed -= TestOnSpacePressed;
    }
}


