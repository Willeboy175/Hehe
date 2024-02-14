using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Yes()
    {
        SceneManager.LoadScene("Marry");
    }

    public virtual void No()
    {
        int rng = Mathf.RoundToInt(Random.Range(0, 4));

        SceneManager.LoadScene("Scene" + rng);
    }
}
