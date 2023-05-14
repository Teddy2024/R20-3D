using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TestEvents : MonoBehaviour
{
    public static int staticNumber;
    New Hello = new New(10);//= new()實例化

    //EventHandler有資料庫
    public EventHandler<onSpacePressedEventArgs> onSpacePressed;     
    public class onSpacePressedEventArgs : EventArgs
    {
        public int localEventNumber;
        public float EventFloat;
        public onSpacePressedEventArgs(){}
        public onSpacePressedEventArgs(int _localEventNumber, float _EventFloat)
        {
            this.localEventNumber = _localEventNumber;
            this.EventFloat = _EventFloat;
        }
    }

    
    void Update()
    {
        //EventHandler調用
        if(Input.GetKeyDown(KeyCode.Space))
        {
            onSpacePressed?.Invoke(this, new onSpacePressedEventArgs{localEventNumber = 2});
            onSpacePressed?.Invoke(this, new onSpacePressedEventArgs(10,0.5f));
        }
    }

    public static void Change()
    {
        staticNumber++;
        Debug.Log(staticNumber);
    }
}

//= new()實例化
public class New
{
    public int J{ get; set; }

    public New(int j)
    {
        J = j;
    }
    public void NewTest()
    {
        J++;
        Debug.Log(J);
    }
}

public class TestStatic
{
    private void TestStaticFunction()
    {
        TestEvents.staticNumber++;
        Debug.Log(TestEvents.staticNumber);
    }
}
