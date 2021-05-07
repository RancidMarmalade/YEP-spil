using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{   //disse lister er dem som opbevare dataen. 
    public List<float> DataRed;
    public List<float> DataBlue;
    public List<float> DataIncreaseBlue;
    public List<float> DataIncreaseRed;

    public float[] DataRedArray = new float[11];
    public float[] DataBlueArray = new float[11];
    // Start is called before the first frame update
    void Start()//Denne funktion starter de funktioner som gemmer dataen fra spillet.
    {
        InvokeRepeating("AddData", 5.01f, 5);
        InvokeRepeating("Saver", 5.01f, 5);
        Invoke("Save", 28.9f);
    }
    void AddData() {//Her tilføjes den data som vi skal gemme til en liste. 
        DataBlue.Add(PlayerPrefs.GetFloat("BlueCount"));
        DataRed.Add(PlayerPrefs.GetFloat("RedCount"));
        DataIncreaseBlue.Add(PlayerPrefs.GetFloat("BlueReproCount"));
        DataIncreaseRed.Add(PlayerPrefs.GetFloat("RedReproCount"));
    }
    void Save()//Denne funktion gemmer den liste som forrige funktion lavede, sådan så vi kan bruge den i stats scenen. 
    {
        for (int i = 0; i < 11; i++)//dette for loop, gemmer dataen lige inde scenerne skifter til stats. 
        {
            DataRedArray[i] = DataRed[i];
            PlayerPrefs.SetFloat("Red" + i, DataRedArray[i]);
            DataBlueArray[i] = DataBlue[i];
            PlayerPrefs.SetFloat("Blue" + i, DataBlueArray[i]);
        }
    }
}
