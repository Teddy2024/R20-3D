using UnityEngine;

public class AppleRottenState : AppleBaseState
{
    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("RottenState");
    }

    public override void UpdateState(AppleStateManager apple)
    {

    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
    {

    }
}
