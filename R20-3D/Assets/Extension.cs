using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extension : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private void OnEnable() 
    {
        transform.DestroyChildren();
        transform.position = transform.position.With(z:10);
        Debug.Log("BACK");
    }
    private void OnMouseEnter() 
    {
        _renderer.Fade(1);
    }

    private void OnMouseExit() 
    {
        _renderer.Fade(0.01f);
    }
}


public static class ExtensionMethods
{
    public static void Fade(this Renderer renderer,float alpha)
   {
        var color = renderer.material.color;
        color.a = alpha;
        renderer.material.color = color;
   }

   public static T Rand<T>(this IList<T> list)
   {
    return list[Random.Range(0,list.Count)];
   }

   public static Vector3 With(this Vector3 original, float? x = null, float? y = null, float? z = null)
   {
    return new Vector3(x?? original.x, y?? original.y, z?? original.z);
   }



   //Y軸統一為零//
   public static Vector3 Flat(this Vector3 input) => new Vector3(input.x, 0 ,input.z);
   //摧毀所有子物件//
   public static void DestroyChildren(this Transform t)
   {
    foreach (Transform children in t)
    {
        Object.Destroy(children.gameObject);
    }
   }
   //物件與子物件設為一樣Layer//
   public static void SetLayerRecursiverly(this GameObject gameObject, int layer)
   {
    gameObject.layer = layer;
    foreach (Transform t in gameObject.transform) t.gameObject.SetLayerRecursiverly(layer);
   }
   //三軸變兩軸//
   public static Vector2 ToV2(this Vector3 input) => new Vector2(input.x, input.y);
   //三軸轉整數//
   public static Vector3Int ToVector3Int(this Vector3 vec3) => new Vector3Int((int)vec3.x, (int)vec3.y, (int)vec3.z);
}

