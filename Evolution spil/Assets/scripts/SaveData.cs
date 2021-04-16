using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public List<float> DataRed;
    public List<float> DataBlue;
    public List<float> DataIncreaseBlue;
    public List<float> DataIncreaseRed;

    public float[] DataRedArray = new float[5];
    public float[] DataBlueArray = new float[5];
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddData", 5.01f, 5);
        InvokeRepeating("Saver", 5.01f, 5);
        Invoke("Save", 29.9f);
    }
    void AddData() {
        DataBlue.Add(PlayerPrefs.GetFloat("BlueCount"));
        DataRed.Add(PlayerPrefs.GetFloat("RedCount"));
        DataIncreaseBlue.Add(PlayerPrefs.GetFloat("BlueReproCount"));
        DataIncreaseRed.Add(PlayerPrefs.GetFloat("RedReproCount"));
    }
    void Save()
    {
        for (int i = 0; i < 5; i++)
        {
            DataRedArray[i] = DataRed[i];
            PlayerPrefs.SetFloat("Red" + i, DataRedArray[i]);
            DataBlueArray[i] = DataBlue[i];
            PlayerPrefs.SetFloat("Blue" + i, DataBlueArray[i]);
        }
    }
}
