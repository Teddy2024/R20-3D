using UnityEngine;
using DG.Tweening;

public class DotTest001 : MonoBehaviour
{
    [SerializeField] private Transform inner, outer;
    [SerializeField] private float _speed = 2;

    void Start()
    {
        transform.DOMove(new Vector3(6,0,0), _speed).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Restart);

        inner.DORotate(new Vector3(0,360,0), _speed * 0.5f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);

        inner.DOLocalMove(new Vector3(0,1.5f,0), _speed * 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
