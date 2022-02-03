using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // SceneChange with buttons
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    
}
