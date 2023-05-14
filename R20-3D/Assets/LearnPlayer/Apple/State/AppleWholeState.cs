using UnityEngine;

public class AppleWholeState : AppleBaseState
{
    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("WholeState");
        apple.GetComponent<Rigidbody>().useGravity = true;
        Animator anim = apple.GetComponent<Animator>();
        anim.Play("Base Layer.AppleAnimation", 0, 0);
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if(apple.rottenTimer >= 0)
        {
            apple.rottenTimer -= Time.deltaTime;
        }
        else
        {
            apple.SwitchState(apple.RottenState);
        }
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
    {
        GameObject other = collision.gameObject;
        if(other.CompareTag("Player"))
        {
            apple.SwitchState(apple.ChewedState);
        }
    }
}
