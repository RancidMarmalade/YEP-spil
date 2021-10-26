using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public List<int> DataRed;
    public List<int> DataBlue;

    public int blue, red, roundCount;

    public int[] DataRedArray;
    public int[] DataBlueArray;
    // Start is called before the first frame update
    void Start()
    {
        roundCount = 0;
        InvokeRepeating("AddData", 5.01f, 5);
        Invoke("Save", 58.9f);
    }
    void AddData() {
        roundCount = roundCount + 1;
        blue = (int)PlayerPrefs.GetFloat("BlueCount");
        DataBlue.Add(blue);
        red = (int)PlayerPrefs.GetFloat("RedCount");
        DataRed.Add(red);
        if (blue <= 1)
        {
            Save();
        }
        else if (red < 1)
        {
            Save();
        }
        checkIfDead();
    }
    void Save()
    {
        for (int i = 0; i < 11; i++)
        {
            PlayerPrefs.DeleteKey("Red" + i);
            PlayerPrefs.DeleteKey("Blue" + i);
        }
        DataRedArray = new int[roundCount];
        DataBlueArray = new int[roundCount];
        for (int i = 0; i < roundCount; i++)
        {
            DataRedArray[i] = DataRed[i];
            PlayerPrefs.SetFloat("Red" + i, DataRedArray[i]);
            DataBlueArray[i] = DataBlue[i];
            PlayerPrefs.SetFloat("Blue" + i, DataBlueArray[i]);
        }
        SceneManager.LoadScene(3);
    }
    void checkIfDead()
    {
        blue = (int)PlayerPrefs.GetFloat("BlueCount");
        red = (int)PlayerPrefs.GetFloat("RedCount");
        if (red < 1 || blue < 1)
        {
            Save();
        }
    }
}
