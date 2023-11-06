using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    public GameObject npcText;
    public GameObject npcMarker;
    private bool endTalk = false;


    private void Update()
    {
        if(endTalk == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                npcText.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            npcText.SetActive(true);
            npcMarker.SetActive(false);
            endTalk = true;

        }
     
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            npcText.SetActive(false);
            endTalk = false;
        }
    }
}
