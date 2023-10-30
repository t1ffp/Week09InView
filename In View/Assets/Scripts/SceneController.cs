using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
 
    public GameObject startScreen;

    private void Start()
    {
        Time.timeScale = 0f;
        startScreen.SetActive(true);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startScreen.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}
