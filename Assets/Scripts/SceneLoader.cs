using System;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SceneLoader : MonoBehaviour
{

    public static void ChangeScene(String SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}