using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleStateManager : MonoBehaviour
{
    AppleBaseState currentState;
    public AppleRottenState RottenState = new AppleRottenState();
    public AppleGrowingState GrowingState = new AppleGrowingState();
    public AppleChewedState ChewedState = new AppleChewedState();
    public AppleWholeState WholeState = new AppleWholeState();
    
    public float rottenTimer = 10f;

    void Start()
    {
        currentState = GrowingState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    void OnCollisionEnter(Collision collision) 
    {
        currentState.OnCollisionEnter(this, collision);
    }

    public void SwitchState(AppleBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
