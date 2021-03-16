using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReproRedPlus : MonoBehaviour
{
    public Text value;
    private float Repro_Nr = 1;

    void Start()
    {
        Repro_Nr = PlayerPrefs.GetFloat("ReproRed");
        value.text = "" + Repro_Nr;
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Repro_Nr = PlayerPrefs.GetFloat("ReproRed");
            if (Repro_Nr <= 9)
            {
                Repro_Nr = Repro_Nr + 1;
                PlayerPrefs.SetFloat("ReproRed", Repro_Nr);
            }
            else
            {
                Repro_Nr = 1;
                PlayerPrefs.SetFloat("ReproRed", Repro_Nr);
            }
            value.text = "" + Repro_Nr;
            Debug.Log("Repruduction Value RED = " + Repro_Nr);
        }
    }
}
