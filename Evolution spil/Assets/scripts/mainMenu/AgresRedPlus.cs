using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgresRedPlus : MonoBehaviour
{
    public Text value;
    private int Agres_Nr = 1;

    void Start()
    {
        Agres_Nr = PlayerPrefs.GetInt("AgresRed");
        value.text = "" + Agres_Nr;
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Agres_Nr = PlayerPrefs.GetInt("AgresRed");
            if (Agres_Nr <= 4)
            {
                Agres_Nr = Agres_Nr + 1;
                PlayerPrefs.SetInt("AgresRed", Agres_Nr);
            }
            else
            {
                Agres_Nr = 1;
                PlayerPrefs.SetInt("AgresRed", Agres_Nr);
            }
            value.text = "" + Agres_Nr;
            Debug.Log("Agression Value RED = " + Agres_Nr);
        }
    }
}
