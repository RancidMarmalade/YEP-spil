using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantieter : MonoBehaviour
{
    public GameObject Blue;
    public GameObject Red;

    public float blueCount = 10;
    public float redCount = 10;

    private float newBlueCount;
    private float newBlueCount_1;
    private float newBlueCount_2;
    private float addedBlue;

    private float newRedCount;
    private float newRedCount_1;
    private float newRedCount_2;
    private float addedRed;

    public float reproBlue;
    public float reproRed;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < blueCount; i++)
        {
            GameObject blue = Instantiate(Blue);
            blue.transform.localPosition = new Vector3(-8, 0.1f, Random.Range(-4, 4));
            PlayerPrefs.SetFloat("BlueCount", blueCount);
        }

        for (int i = 0; i < redCount; i++)
        {
            GameObject red = Instantiate(Red);
            red.transform.localPosition = new Vector3(8, 0.12f, Random.Range(-4, 4));
            PlayerPrefs.SetFloat("RedCount", redCount);
        }
        InvokeRepeating("ReproBlue", 5, 5);
        InvokeRepeating("ReproRed", 5, 5);

    }
    void ReproBlue()
    {
        newBlueCount = PlayerPrefs.GetFloat("BlueCount");
        reproBlue = PlayerPrefs.GetFloat("ReproBlue");
        Debug.Log("RRR " + reproBlue);
        Debug.Log("OOO " + newBlueCount);
        if (reproBlue == 1)
        {
            newBlueCount_1 = newBlueCount * 0.1f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        else if (reproBlue == 2)
        {
            newBlueCount_1 = newBlueCount * 0.2f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        else if (reproBlue == 3)
        {
            newBlueCount_1 = newBlueCount * 0.3f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        else if (reproBlue == 4)
        {
            newBlueCount_1 = newBlueCount * 0.4f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        else if (reproBlue == 5)
        {
            newBlueCount_1 = newBlueCount * 0.5f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        else if (reproBlue == 6)
        {
            newBlueCount_1 = newBlueCount * 0.6f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        else if (reproBlue == 7)
        {
            newBlueCount_1 = newBlueCount * 0.7f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        else if (reproBlue == 8)
        {
            newBlueCount_1 = newBlueCount * 0.8f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        else if (reproBlue == 9)
        {
            newBlueCount_1 = newBlueCount * 0.9f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        else if (reproBlue == 10)
        {
            newBlueCount_1 = newBlueCount * 1f;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
        }
        for (int i = 0; i < newBlueCount_2; i++)
        {
            GameObject blue = Instantiate(Blue);
            blue.transform.localPosition = new Vector3(-8, 0.1f, Random.Range(-4, 4));
        }
        addedBlue = newBlueCount + newBlueCount_2;
        PlayerPrefs.SetFloat("BlueCount", addedBlue);
        Debug.Log("NNN " + addedBlue);
    }

    void ReproRed()
    {
        newRedCount = PlayerPrefs.GetFloat("RedCount");
        reproRed = PlayerPrefs.GetFloat("ReproRed");
        Debug.Log("RRR " + reproBlue);
        Debug.Log("OOO " + newRedCount);
        if (reproBlue == 1)
        {
            newRedCount_1 = newRedCount * 0.1f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        else if (reproBlue == 2)
        {
            newRedCount_1 = newRedCount * 0.2f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        else if (reproBlue == 3)
        {
            newRedCount_1 = newRedCount * 0.3f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        else if (reproBlue == 4)
        {
            newRedCount_1 = newRedCount * 0.4f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        else if (reproBlue == 5)
        {
            newRedCount_1 = newRedCount * 0.5f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        else if (reproBlue == 6)
        {
            newRedCount_1 = newRedCount * 0.6f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        else if (reproBlue == 7)
        {
            newRedCount_1 = newRedCount * 0.7f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        else if (reproBlue == 8)
        {
            newRedCount_1 = newRedCount * 0.8f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        else if (reproBlue == 9)
        {
            newRedCount_1 = newRedCount * 0.9f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        else if (reproBlue == 10)
        {
            newRedCount_1 = newRedCount * 1f;
            newRedCount_2 = Mathf.Round(newRedCount_1);
        }
        for (int i = 0; i < newRedCount_2; i++)
        {
            GameObject red = Instantiate(Red);
            red.transform.localPosition = new Vector3(8, 0.12f, Random.Range(-4, 4));
        }
        addedRed = newRedCount + newRedCount_2;
        PlayerPrefs.SetFloat("RedCount", addedRed);
        Debug.Log("NNN " + addedRed);
    }
}