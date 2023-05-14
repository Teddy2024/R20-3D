using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnGenerics : MonoBehaviour
{
    private void Start() 
    {
        // CreateArray<int>(1, 2);
        // CreateArray("123", "321");
        // //Debug.Log(CreateArray(3,4).Length);
        // TestCreateArray<int>(10);
        // TestCreateArray(10);
        // TestCreateArray("Loop Her");

        var hero01 = new Hero(){name = "Hero01"};
        MyClass<Hero> heroClass = new MyClass<Hero>(hero01);
        

    }

    // private T[] CreateArray<T>(T first, T second)
    // {
    //     return new T[] {first, second};
    // }
    // private void TestCreateArray<T>(T input)
    // {
    //     Debug.Log(input);
    // }
}

public class MyClass<T> where T : Hero
{
    public T value;

    public MyClass(T value)
    {
        value.Damage();
        Debug.Log(value);
    }

}
public class Hero : IEnemy
{
    public string name;
    public void Damage()
    {
        Debug.Log("999999999");
    }
}
public interface  IEnemy
{
    void Damage();
}
