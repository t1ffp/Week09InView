using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DetectAlien : MonoBehaviour
{
    private bool canInteract = false;
    public GameObject interactText;
    public Image flashImg;
    public float flashSpd = 1.5f;

    public AudioSource camFlash;
    public AudioSource alienScream;

    private void Update()
    {  
        if (canInteract == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                flashImg.color = Color.white;
                camFlash.Play();
                alienScream.Play();

                AlienManager alienManager = FindObjectOfType<AlienManager>();
                if (alienManager != null)
                {
                    alienManager.aliensLeft--;
                }
               
                Destroy(this.gameObject, 2f);
                interactText.SetActive(false);
                flashImg.color = Color.Lerp(flashImg.color, Color.clear, flashSpd * Time.deltaTime);
            }
            else
            {
                flashImg.color = Color.Lerp(flashImg.color, Color.clear, flashSpd * Time.deltaTime);

            }

        }
        else
        {
            canInteract = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("hit");
            canInteract = true;
            interactText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canInteract = false;
        interactText.SetActive(false);
    }
}
