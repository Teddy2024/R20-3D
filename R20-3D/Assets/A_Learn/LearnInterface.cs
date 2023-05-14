using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnInterface
{
   
}

public interface IDamageable
{
    int damage {get; set;}
    void Damage();
}

public interface IInvinsonble
{
    void AnotherDamage();
}

public abstract class Damageable : MonoBehaviour, IDamageable , IInvinsonble
{
    [SerializeField ] private int health;
    public int damage{get;set;}

    public void Damage()
    {
        Debug.Log("Hurt!!!");
    }
    public void NoDamage()
    {
        Debug.Log("No Hurt!!!");
    }
    public void AnotherDamage()
    {
        Debug.Log(health);
    }
}
