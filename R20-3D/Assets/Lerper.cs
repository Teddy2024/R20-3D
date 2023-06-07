using UnityEngine;

public class Lerper : MonoBehaviour
{
    public AnimationCurve animCurve;
    public Vector3 goalRotation;
    public Vector3 currentPosition, goalPosition;
    public float _scaleLevel;
    public float speed = 0.5f;
    private float _current, _target;
    private float i;

    [ContextMenuItem("Mathf", nameof(SetMathf))] public float value;

    private void SetMathf() 
    {
        value = Mathf.Lerp(1, 100, i);
        Debug.Log(value);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) _target = _target == 0 ? 1 : 0;
        _current = Mathf.MoveTowards(_current, _target, speed * Time.deltaTime);

        transform.position = Vector3.Slerp(currentPosition, goalPosition, animCurve.Evaluate(_current));
        transform.rotation = Quaternion.Slerp(
            Quaternion.Euler(Vector3.zero), Quaternion.Euler(goalRotation), animCurve.Evaluate(_current));
        transform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * _scaleLevel, animCurve.Evaluate(Mathf.PingPong(_current, 0.5f) * 2));
    }
}