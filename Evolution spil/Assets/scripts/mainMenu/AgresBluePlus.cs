using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgresBluePlus : MonoBehaviour
{
    public Text value;
    private int Agres_Nr = 1;

    void Start()
    {
        Agres_Nr = PlayerPrefs.GetInt("AgresBlue");
        value.text = "" + Agres_Nr;
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Agres_Nr = PlayerPrefs.GetInt("AgresBlue");
            if (Agres_Nr <= 4)
            {
                Agres_Nr = Agres_Nr + 1;
                PlayerPrefs.SetInt("AgresBlue", Agres_Nr);
            }else
            {
                Agres_Nr = 1;
                PlayerPrefs.SetInt("AgresBlue", Agres_Nr);
            }
            value.text = "" + Agres_Nr;
            Debug.Log("Agression Value BLUE = " + Agres_Nr);
        }
    }
}
