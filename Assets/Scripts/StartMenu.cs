using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public virtual void Yes()
    {
        SceneManager.LoadScene("Marry");
    }

    public void Yes2()
    {
        SceneManager.LoadScene("Yaaay");
    }

    public virtual void No()
    {
        int rng = 0;
        string newScene = "Scene";
        string currentScene = "Scene";

        while (newScene == currentScene)
        {
            rng = Mathf.RoundToInt(Random.Range(0, 4));
            newScene = "Scene" + rng;
            currentScene = SceneManager.GetActiveScene().name;
            print("newScene: " + newScene + " and " + "currentScene " + currentScene);
        }

        SceneManager.LoadScene("Scene" + rng);
    }
}
