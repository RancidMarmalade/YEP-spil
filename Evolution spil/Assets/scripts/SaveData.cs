using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public List<float> DataRed;
    public List<float> DataBlue;
    public List<float> DataIncreaseBlue;
    public List<float> DataIncreaseRed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddData", 5.01f, 5);
        InvokeRepeating("Saver", 5.01f, 5);
    }
    void AddData() {
        DataBlue.Add(PlayerPrefs.GetFloat("BlueCount"));
        DataRed.Add(PlayerPrefs.GetFloat("RedCount"));
        DataIncreaseBlue.Add(PlayerPrefs.GetFloat("BlueReproCount"));
        DataIncreaseRed.Add(PlayerPrefs.GetFloat("RedReproCount"));
    }
    void Saver()
    {/*
        PlayerPrefs.SetFloat("Blue1", DataBlue.FindLastIndex);
        PlayerPrefs.SetFloat("Blue2", DataBlue.FindLastIndex);
        */
    }
}
