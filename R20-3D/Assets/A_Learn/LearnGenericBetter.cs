using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnGenericBetter : MonoBehaviour
{
    private void Start() 
    {
        var warrior = new Warrior(){dmg = 10, Nam = "Junk Warrior"};
        var heroHelper = new HeroHelper<Warrior>(warrior);

        heroHelper.Print();
        heroHelper.ForceAttack();

    }
}

public class HeroHelper<T> where T : EHero
{
    public T Data;

    public  HeroHelper(T data)
    {
        Data = data;
    }
    public void Print()
    {
        Debug.Log(Data);
    }
    public void ForceAttack()
    {
        Data.Attack();
    }
}

public abstract class EHero
{
    public int dmg;
    public string Nam;

    public void Attack()
    {
        Debug.Log(Nam + dmg);
    }
}

public class Mage : EHero
{
    
}
public class Warrior : EHero
{
    
}