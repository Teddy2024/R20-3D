using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnNew : MonoBehaviour
{
    private void Start() 
    {
        Person Kevin = new Person("Kevin" , 21);
        Debug.Log(Kevin.Name + Kevin.Age);
    }
}

public class Person 
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age) 
    {
        Name = name;
        Age = age;
    }
}
// public class Person 
// {
//     public string name;
//     public int age;

//     public Person(string name, int age) 
//     {
//         this.name = name;
//         this.age = age;
//     }
// }