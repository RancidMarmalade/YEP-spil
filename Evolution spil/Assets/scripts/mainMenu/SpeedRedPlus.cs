using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedRedPlus : MonoBehaviour
{
    public Text value;
    private int Speed_Nr = 1;

    void Start()
    {
        Speed_Nr = PlayerPrefs.GetInt("SpeedRed");
        value.text = "" + Speed_Nr;
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Speed_Nr = PlayerPrefs.GetInt("SpeedRed");
            if (Speed_Nr <= 9)
            {
                Speed_Nr = Speed_Nr + 1;
                PlayerPrefs.SetInt("SpeedRed", Speed_Nr);
            }
            else
            {
                Speed_Nr = 1;
                PlayerPrefs.SetInt("SpeedRed", Speed_Nr);
            }
            value.text = "" + Speed_Nr;
            Debug.Log("Speed Value Red = " + Speed_Nr);
        }
    }
}

