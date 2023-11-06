using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AlienManager : MonoBehaviour
{
    public int alienCount = 3;

    public int aliensLeft;



    public GameObject endScreen;
    private float screenDelay = 1.7f;


    // Start is called before the first frame update
    void Start()
    {
        aliensLeft = alienCount;
    }

    private void Update()
    {
       

        if (aliensLeft == 0)
        {
            StartCoroutine(ScreenDelay());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Start");
        }
    }

    private IEnumerator ScreenDelay()
    {
        yield return new WaitForSeconds(screenDelay);
        {
            if (endScreen != null)
            {
                endScreen.SetActive(true);
            }
        }
    }


}
