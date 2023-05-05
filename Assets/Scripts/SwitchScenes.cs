using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        NextScene();
    }

    private static void NextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (Input.anyKey)
        {
            currentScene++;
            SceneManager.LoadScene(currentScene);
        }
    }
}
