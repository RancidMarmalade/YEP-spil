using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePlus : MonoBehaviour
{
    public Text value;
    private float Life_nr = 1;

    void Start()
    {
        Life_nr = PlayerPrefs.GetFloat("Life");
        value.text = "" + Life_nr;
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Life_nr = PlayerPrefs.GetFloat("Life");
            if (Life_nr <= 4)
            {
                Life_nr = Life_nr + 1;
                PlayerPrefs.SetFloat("Life", Life_nr);
            }
            else
            {
                Life_nr = 1;
                PlayerPrefs.SetFloat("Life", Life_nr);
            }
            value.text = "" + Life_nr;
            Debug.Log("Life Value = " + Life_nr);
        }
    }
}