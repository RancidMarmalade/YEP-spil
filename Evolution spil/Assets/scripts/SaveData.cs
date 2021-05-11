using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public List<float> DataRed;
    public List<float> DataBlue;
    public List<float> DataIncreaseBlue;
    public List<float> DataIncreaseRed;

    public float[] DataRedArray = new float[11];
    public float[] DataBlueArray = new float[11];
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddData", 5.01f, 5);
        Invoke("Save", 58.9f);
    }
    void AddData() {
        DataBlue.Add(PlayerPrefs.GetFloat("BlueCount"));
        float blue = PlayerPrefs.GetFloat("BlueCount");
        if (blue <= .9f)
        {
            Save();
        }
        DataRed.Add(PlayerPrefs.GetFloat("RedCount"));
        float red = PlayerPrefs.GetFloat("RedCount");
        if (red <= .9f)
        {
            Save();
        }
        DataIncreaseBlue.Add(PlayerPrefs.GetFloat("BlueReproCount"));
        DataIncreaseRed.Add(PlayerPrefs.GetFloat("RedReproCount"));
    }
    void Save()
    {
        for (int i = 0; i < 11; i++)
        {
            DataRedArray[i] = DataRed[i];
            PlayerPrefs.SetFloat("Red" + i, DataRedArray[i]);
            DataBlueArray[i] = DataBlue[i];
            PlayerPrefs.SetFloat("Blue" + i, DataBlueArray[i]);
        }
        SceneManager.LoadScene(3);
    }
}
