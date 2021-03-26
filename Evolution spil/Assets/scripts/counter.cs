using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    public Text BlueCount;
    public Text RedCount;

    public float blueCount;
    public float redCount;

    // Update is called once per frame
    void Update()
    {
        redCount = PlayerPrefs.GetFloat("RedCount");
        blueCount = PlayerPrefs.GetFloat("BlueCount");
        InvokeRepeating("blueCounter", 0.01f, 0.1f);
        InvokeRepeating("redCounter", 0.01f, 0.1f);
    }

    void redCounter()
    {
        RedCount.text = "" + redCount;
    }

    void blueCounter()
    {
        BlueCount.text = "" + blueCount;
    }
}
