using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    // public Item sword;
    // public Item shield;
    public Item[] items;
    private int _id;


    void Start()
    {
        _id = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItemTest()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _id = 0;
            Debug.Log(items[_id].itemName + items[_id].itemID + items[_id].itemDescription);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _id = 1;
            Debug.Log(items[_id].itemName + items[_id].itemID + items[_id].itemDescription);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            _id = 2;
            Debug.Log(items[_id].itemName + items[_id].itemID + items[_id].itemDescription);
        }
    }

   
}
