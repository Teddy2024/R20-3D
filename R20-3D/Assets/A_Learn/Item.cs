using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public string itemName;
    public int itemID;
    public string itemDescription;
    public Sprite icon;

    public Item()
    {

    }

    public Item(string itemName, int itemID, string itemDescription)
    {
        this.itemName = itemName;
        this.itemID = itemID;
        this.itemDescription = itemDescription;
    }
}
