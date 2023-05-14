using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCast : MonoBehaviour
{
    [SerializeField] ItemDatabase itemDatabase;
    //[SerializeField] private GameObject itemDataManager;


    void Awake()
    {
        //itemDatabase = itemDataManager.GetComponent<ItemDatabase>();
    }

    // Update is called once per frame
    void Update()
    {
       itemDatabase.ItemTest();
    }
}
