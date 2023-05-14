using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon 
{
    public float firePower;
    public int bulletNumber;
    public string gunName;

    public Weapon(float firePower, int bulletNumber, string gunName)
    {
        this.firePower = firePower;
        this.bulletNumber = bulletNumber;
        this.gunName = gunName;
    }
}

public class LearnClass : MonoBehaviour //學習調用其他Class
{
    public Weapon Gun;
    public Weapon superGun;
  
    int[] cards = new int[] {1, 2, 3, 4};
    //整數數組[]
    List<int> cardList = new List<int>() {1, 2, 3, 4};
    //整數列表List

    MyClass myClass = new MyClass();
    //調動Class裡的MyClass並取名myClass

    private void Start() 
    {
        Gun = new Weapon(10,1,"Gun");
        superGun = new Weapon(30,10,"superGun");


        myClass.i = 0;
        //使用取名myClass的變數
        myClass.MyClassOne();
        //使用取名myClass的函數

        Debug.Log(Gun.gunName);
    }
   

    class MyClass
    {
        public int i = 10;
        public void MyClassOne()
        {
            Debug.Log(i);
        }
        
    }
    //MyClass並被取名myClass
}
