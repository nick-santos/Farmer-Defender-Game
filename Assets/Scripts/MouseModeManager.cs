using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class MouseModeManager : MonoBehaviour
{
    public GameObject MouseMode;
    public GameObject Placeholder1;

    // public GameOverScreen GameOverScreen;

    // public void GameOver()
    // {
    //     GameOverScreen.Setup();
    // }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (MouseMode.GetComponent<MousePosition>().enabled == true)
            {
                MouseMode.GetComponent<MousePosition>().enabled = false;
                Placeholder1.SetActive(false);
            }
            else
            {
                MouseMode.GetComponent<MousePosition>().enabled = true;
                Placeholder1.SetActive(true);
            }
        }
    }
}
