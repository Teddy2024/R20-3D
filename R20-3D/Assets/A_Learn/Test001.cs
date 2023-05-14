using System.Collections;
using UnityEngine;
using System.Threading.Tasks;

public class Test001 : MonoBehaviour
{
    [SerializeField] private Test002[] _shapes;

    public async void RotateTest()
    {
        var tasks = new Task[_shapes.Length];
        for (int i = 0; i < _shapes.Length; i++)
        {
            tasks[i] =  _shapes[i].RotateForSeconds(1 + 1 * i);
        }

        await Task.WhenAll(tasks);
        
        Debug.Log("ALL FINSH");
    }
}
