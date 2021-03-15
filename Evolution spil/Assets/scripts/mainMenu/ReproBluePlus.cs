using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReproBluePlus : MonoBehaviour
{
    public Text value;
    private int Repro_Nr = 1;

    void Start()
    {
        Repro_Nr = PlayerPrefs.GetInt("ReproBlue");
        value.text = "" + Repro_Nr;
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Repro_Nr = PlayerPrefs.GetInt("ReproBlue");
            if (Repro_Nr <= 9)
            {
                Repro_Nr = Repro_Nr + 1;
                PlayerPrefs.SetInt("ReproBlue", Repro_Nr);
            }
            else
            {
                Repro_Nr = 1;
                PlayerPrefs.SetInt("ReproBlue", Repro_Nr);
            }
            value.text = "" + Repro_Nr;
            Debug.Log("Repruduction Value BLUE = " + Repro_Nr);
        }
    }
}
