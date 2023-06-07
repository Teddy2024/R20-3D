using UnityEngine;

public class Instantuater : MonoBehaviour
{
    [SerializeField]  private SphereTest _sphereTest;
    private void Start() 
    {
        Instantiate(_sphereTest, transform.position, Quaternion.identity);
    }
}