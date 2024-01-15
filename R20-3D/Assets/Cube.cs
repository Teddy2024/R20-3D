using UnityEngine;

public class Cube : MonoBehaviour
{
    public float _bazeSize = 2;
    public string _text;

    private void Start() 
    {
        Debug.Log(_text);
        GenerateColor();
    }

    private void Update() 
    {
        float animation = _bazeSize + Mathf.Sin(Time.time * 8f) * _bazeSize/ 7f;
        transform.localScale = Vector3.one * animation;
    }

    public void GenerateColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    public void ResetColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }
}
