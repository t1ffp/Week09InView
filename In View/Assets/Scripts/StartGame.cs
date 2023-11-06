using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject interactTxt;
    private bool canLeave = false;


    private void Update()
    {
        if (canLeave == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
              
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactTxt.SetActive(true);
            canLeave = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactTxt.SetActive(false);
            canLeave = false;
        }
    }
}
