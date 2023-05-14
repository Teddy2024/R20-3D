using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnUseQuestionMark : MonoBehaviour
{
    private string nothing = null;
    private bool Bool = true;
    //if(something != null) something?.
    
    private void Start() 
    {
        Debug.Log(nothing ?? "HI");
        Debug.Log(Bool ? "TRUE":"FALSE");
    }

    private void NothingTest()
    {
        Debug.Log("NothingTest");
    }
}
