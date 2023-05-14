using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class AwaitLearn : MonoBehaviour
{
    async void Start()
    {
        await FinalWait();
    }

    private async Task Wait()
    {
        Debug.Log("99997");
        await Task.Yield();
        Debug.Log("99998");
    }

    private async Task FinalWait()
    {
        await Wait();
        Debug.Log("99999");
        await Task.Delay(10000);
        Debug.Log("10000");
    }

}
