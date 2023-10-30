using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AlienManager : MonoBehaviour
{
    public int alienCount = 5;

    public int aliensLeft;

    public TextMeshProUGUI aliensLeftText;

    public GameObject endScreen;
    private float screenDelay = 1.7f;


    // Start is called before the first frame update
    void Start()
    {
        aliensLeft = alienCount;
    }

    private void Update()
    {
        aliensLeftText.text = "Aliens Left: " + aliensLeft.ToString();

        if (aliensLeft == 0)
        {
            StartCoroutine(ScreenDelay());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
