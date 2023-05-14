using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // private void Update() 
    // {
    //     if(Input.GetKeyDown(KeyCode.L))
    //     {
    //         SceneSwitch();
    //     }
    // }

    // private void SceneSwitch()
    // {
    //     if(SceneManager.GetActiveScene().buildIndex == 0)
    //     {
    //         SceneManager.LoadScene(1);
    //     }
    //     else if(SceneManager.GetActiveScene().buildIndex == 1)
    //     {
    //         SceneManager.LoadScene(0);
    //     }
    // }
}
