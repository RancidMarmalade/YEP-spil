using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitHandler : MonoBehaviour
{
    public GameObject Quit;

    public bool Quiting = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if(Quiting == false)
            {
                Time.timeScale = 0;
                Quiting = true;
                Quit.SetActive(true);
            }
            else if (Quiting == true)
            {
                Time.timeScale = 1;
                Quiting = false;
                Quit.SetActive(false);
            }
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
