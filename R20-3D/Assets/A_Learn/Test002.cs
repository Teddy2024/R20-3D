using System.Collections;
using UnityEngine;
using System.Threading.Tasks;

public class Test002 : MonoBehaviour
{
    // public IEnumerator RotateForSeconds(float duration)
    // {
    //     var end = Time.time + duration;
    //     while (Time.time < end)
    //     {
    //         transform.Rotate(new Vector3(1,1) * Time.deltaTime * 150);
    //         yield return null;
    //     }
    // }

    public async Task RotateForSeconds(float duration)
    {
        var end = Time.time + duration;
        while (Time.time < end)
        {
            transform.Rotate(new Vector3(1,1) * Time.deltaTime * 150);
            await Task.Yield();
        }
    }
}
