using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackHeapTest : MonoBehaviour
{
   private void Start() 
   {
      Run();
   }

   void Run()
   {
      var a = new Coords(1,2);
      var b = a;

      b.X = 66;

      Debug.Log(a);
      Debug.Log(b);
   }

   //public class Coords
   public struct Coords
   {
      public Coords(int x, int y)
      {
         X = x;
         Y = y;
      }

      public int X;
      public int Y;

      public override string ToString() => $"{X} ,{Y}";
   }
}
