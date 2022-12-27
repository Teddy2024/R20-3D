using System.Collections;
using UnityEngine;

namespace Teddy
{
    ///<summary>
    ///協同程序Coroutine
    ///</summary>
    public class LearnCoroutine : MonoBehaviour
    {
        //條件有四個
        //using System.Collections
        //IEnumerator的方法
        //方法內 yield return(等待)
        //使用StartCoroutine(啟動)

        private IEnumerator Test()
        {
            Debug.Log("First");
            yield return new WaitForSeconds(2);
            Debug.Log("Second");
        }
    }
}

