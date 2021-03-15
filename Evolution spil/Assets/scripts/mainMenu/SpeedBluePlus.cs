using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBluePlus : MonoBehaviour
{
    public Text value;
    private int Speed_Nr = 1;

    void Start()
    {
        Speed_Nr = PlayerPrefs.GetInt("SpeedBlue");
        value.text = "" + Speed_Nr;
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Speed_Nr = PlayerPrefs.GetInt("SpeedBlue");
            if (Speed_Nr <= 9)
            {
                Speed_Nr = Speed_Nr + 1;
                PlayerPrefs.SetInt("SpeedBlue", Speed_Nr);
            }
            else
            {
                Speed_Nr = 1;
                PlayerPrefs.SetInt("SpeedBlue", Speed_Nr);
            }
            value.text = "" + Speed_Nr;
            Debug.Log("Speed Value BLUE = " + Speed_Nr);
        }
    }
}
