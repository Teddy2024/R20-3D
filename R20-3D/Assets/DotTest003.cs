using UnityEngine;
using DG.Tweening;

public class DotTest003 : MonoBehaviour
{
    [SerializeField] private Transform jump, punch, shake, target;
    [Space(30)]
    [SerializeField] private MeshRenderer change;

    private void Start() 
    {
        DOVirtual.Float(0, 5, 1, v => {Debug.Log(v);}).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        transform.DOMoveX(10, 100).SetSpeedBased(true);
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Keypad1))Jump();
        if(Input.GetKeyDown(KeyCode.Keypad2))Shake();
        if(Input.GetKeyDown(KeyCode.Keypad3))Punch();
        if(Input.GetKeyDown(KeyCode.Keypad4))Change();
    }

    public void Jump()
    {
        jump.DOJump(endValue: new Vector3(5,2,0), jumpPower: 2, numJumps: 3, duration: 1f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    public void Shake()
    {
        const float duration = 0.5f;
        const float strength = 0.5f;

        var tween = shake.DOShakePosition(duration, strength);
        // if(tween.IsPlaying())return;
        // transform.DOKill();
        shake.DOShakeRotation(duration, strength);
        shake.DOShakeScale(duration, strength);
    }

    public void Punch()
    {
        var duration = 0.5f;
        
        punch.DOPunchPosition(
            punch: Vector3.left * 2,
            duration: duration,
            vibrato: 0,
            elasticity: 9999
        );

        target.DOShakePosition(
        duration: 0.5f,
        strength: 0.5f,
        vibrato: 10
        ).SetDelay(duration * 0.5f);
    }

    public void Change()
    {
        change.material.DOColor(Random.ColorHSV(), 0.3f).OnComplete(Change);
    }
}
