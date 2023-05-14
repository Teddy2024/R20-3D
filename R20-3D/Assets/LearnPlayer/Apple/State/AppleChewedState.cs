using UnityEngine;

public class AppleChewedState : AppleBaseState
{
    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("ChewedState");
    }

    public override void UpdateState(AppleStateManager apple)
    {
        Object.Destroy(apple.gameObject);
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
    {

    }
}
