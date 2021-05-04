using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetValues : MonoBehaviour
{

    public float[] DataRedArray = new float[11];
    public float[] DataBlueArray = new float[11];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            float r = Random.Range(20f, 100f);
            float b = Random.Range(2f, 10f);
            DataRedArray[i] = r;
            PlayerPrefs.SetFloat("Red" + i, DataRedArray[i]);
            DataBlueArray[i] = b;
            PlayerPrefs.SetFloat("Blue" + i, DataBlueArray[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
