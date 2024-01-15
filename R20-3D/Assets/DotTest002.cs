using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;
using System.Collections.Generic;

public class DotTest002 : MonoBehaviour
{
    [SerializeField] private Transform[] cubes;
    [SerializeField] private float goal = 10;

    private void Start() 
    {
        #region DOTween
        var sequence = DOTween.Sequence();
        foreach(var cube in cubes)
        {
            sequence.Append(cube.DOMoveX(goal, Random.Range(1f, 2f)));
        }
        sequence.OnComplete(() => 
        {
            foreach(var cube in cubes)
            {
                cube.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBounce);
            }
        });
        #endregion
        #region BAD
        // cubes[0].DOMoveX(goal, Random.Range(1f, 2f)).OnComplete(() => 
        // {
        //     cubes[1].DOMoveX(goal, Random.Range(1f, 2f)).OnComplete(() => 
        //     {
        //         cubes[2].DOMoveX(goal, Random.Range(1f, 2f)).OnComplete(() =>
        //         {
        //             foreach(var cube in cubes)
        //             {
        //                 cube.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBounce);
        //             }
        //         });
        //     });
        // });
        #endregion
        AsyncBoy();
    }

    #region Async
    async void AsyncBoy()
    {
        foreach(var cube in cubes)
        {
            await cube.DOMoveX(goal, Random.Range(1f, 2f)).SetEase(Ease.InOutQuad).AsyncWaitForCompletion();
        }
    }
    async void Tasks()
    {
        var tasks = new List<Task>();

        foreach(var cube in cubes)
        {
            tasks.Add(cube.DOMoveX(goal, Random.Range(1f, 2f)).SetEase(Ease.InOutQuad).AsyncWaitForCompletion());
        }

        await Task.WhenAll(tasks);

        foreach(var cube in cubes)
        {
            cube.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBounce);
        }
    }
    #endregion
}
