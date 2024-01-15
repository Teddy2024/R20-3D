using UnityEngine;

public class UICube : MonoBehaviour
{
    float _targetScale = 1;
    Vector3 _scaleVal;
    Quaternion _targetRotation;

    private void OnEnable() 
    {
        UITest.ScaleChanged += OnScaleChanged;
        UITest.SpinClicked += OnSpinClicked;
    }

    private void OnDisable() 
    {
        UITest.ScaleChanged -= OnScaleChanged;
        UITest.SpinClicked -= OnSpinClicked;
    }

    private void Update() 
    {
        transform.localScale = 
        Vector3.SmoothDamp(transform.localScale, _targetScale * Vector3.one, ref _scaleVal, 0.15f);
        
        transform.rotation = 
        Quaternion.Slerp(transform.rotation, _targetRotation, Time.deltaTime * 5f);
    }

    private void OnScaleChanged(float newscale)
    {
        _targetScale = newscale;
    }

    private void OnSpinClicked()
    {
        _targetRotation = transform.rotation * Quaternion.Euler(Random.insideUnitSphere * 360);
    }
}
