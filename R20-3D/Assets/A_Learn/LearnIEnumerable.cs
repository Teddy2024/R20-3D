using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Linq;

public class LearnIEnumerable : MonoBehaviour
{
    // IEnumerable<int> GetNumbers()
    // {
    //     for (int i = 0; i < 1000; i++)
    //     {
    //         //Debug.Log(i);
    //         yield return i;
    //     }
    // }
    private void Start() 
    {
        var heroSchool = new School();
        foreach (var item in heroSchool)
        {
            Debug.Log(item);
        }
    }
}

public class School : IEnumerable
{
    public string Name { get; set; } = "Olynpus";

    private List<string> olypians =  new List<string>()
    {
        "Apple","Banana","Cherry"
    };

    public IEnumerator GetEnumerator()
    {
        return olypians.GetEnumerator();
    }
}

//IEnumerable<string> gamesName = gameList.Select(g => g.Name);
// var numbers = Enumerable.Range(0,10).ToList();
//var randomNubers = numbers.OrderBy(n => Random.Next()).Take(3);