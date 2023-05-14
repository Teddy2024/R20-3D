using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Delegate : MonoBehaviour
{

    delegate void CalculateFunction();
    CalculateFunction anotherCalculateFunction;

    private Action<string> actionFunction;
    private Func<int, bool> funcFunction;

    void Start()
    {
        anotherCalculateFunction += () => {Debug.Log("12322298888");};
        // anotherCalculateFunction = (int i) => {Debug.Log(i);};
        anotherCalculateFunction();

        // actionFunction += TestString;
        actionFunction?.Invoke("我是英雄");

        // funcFunction += funcBool;
        // Debug.Log(funcFunction(10));

    }

    void Test123()
    {
        Debug.Log("Test123");
    }

    void Test321()
    {
        Debug.Log("Test321");
    }

    void Test332211(int num)
    {
        Debug.Log(num);
    }

    void TestString(string heroName)
    {
        Debug.Log(heroName);
    }

    bool funcBool(int i)
    {
        return i < 5;
    }
}
