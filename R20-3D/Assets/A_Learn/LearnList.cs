using System.Collections.Generic;
using UnityEngine;
using System;

public class LearnList : MonoBehaviour
{
  public Fruit[] fruitsArray = new Fruit[3];
  public List<Fruit> fruitsList = new List<Fruit>();
  public Dictionary<string, Fruit> fruitsDictionary = new Dictionary<string, Fruit>();

  private void Start() 
  {
    fruitsArray[0] = new Fruit("AALemon", 10f);
    fruitsArray[1] = new Fruit("BBLemon", 10f);
    fruitsArray[2] = new Fruit("CCLemon", 10f);

    fruitsList.Add(new Fruit("AALemon", 10f));
    fruitsList.Add(new Fruit("BBLemon", 10f));
    fruitsList.Add(new Fruit("CCLemon", 10f));

    fruitsDictionary.Add("Juice", new Fruit("AALemon", 10f));
    fruitsDictionary.Add("Normal", new Fruit("BBLemon", 10f));
    fruitsDictionary.Add("Bad", new Fruit("CCLemon", 10f));


    Debug.Log(fruitsArray.Length);
    Debug.Log(fruitsList.Count);
    Debug.Log(fruitsDictionary.Count);
  }
}

public class Fruit 
{
    public string name;
    public float price;

    public Fruit(string name, float price)
    {
        this.name = name;
        this.price = price;
    }
}