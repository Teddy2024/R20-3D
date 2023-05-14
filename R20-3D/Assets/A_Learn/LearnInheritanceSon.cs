using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnInheritance : MonoBehaviour
{
    [SerializeField] 
    protected int peopleCount10 = 10;
    [SerializeField]
    protected int peopleCount9 = 9;
    public int BaseProperty { get; set; }

    public virtual void HIIIIII()
    {
        Debug.Log("HIIIIII");
    }
}

public class LearnInheritanceSon : LearnInheritance
{
    private void Start() 
    {
        Debug.Log(peopleCount10);
        Debug.Log(peopleCount9);
        base.HIIIIII();
        HIIIIII();
    }

    sealed public override void HIIIIII()
    {
        Debug.Log("IIIIIIH");
    } 
}