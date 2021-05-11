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

    public float reproProcentBlue;
    public float reproProcentRed;

    public int reproChanceBlue;
    public int reproChanceRed;

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
        InvokeRepeating("wtf", 5, 5);

    }

    void FixedUpdate()
    {
        //reproChanceBlue = Random.Range(1, 11);
        //reproChanceRed = Random.Range(1, 11);
    }
    void wtf()
    {
        Debug.Log("time to fuck blue things");
    }
    void ReproBlue()
    {
        newBlueCount = PlayerPrefs.GetFloat("BlueCount");
        reproBlue = PlayerPrefs.GetFloat("ReproBlue");
        Debug.Log("b-RRR " + reproBlue);
        Debug.Log("b-OOO " + newBlueCount);

        if (reproChanceBlue <= reproBlue)
        {
            Debug.Log(reproChanceBlue + ":::" + reproBlue);
            reproProcentBlue = reproBlue / 10;

            newBlueCount_1 = newBlueCount * reproProcentBlue;
            newBlueCount_2 = Mathf.Round(newBlueCount_1);
            for (int i = 0; i < newBlueCount_2; i++)
            {
                GameObject blue = Instantiate(Blue);
                blue.transform.localPosition = new Vector3(-8, 0.1f, Random.Range(-4, 4));
              
            }
            addedBlue = newBlueCount + newBlueCount_2;
            PlayerPrefs.SetFloat("BlueCount", addedBlue);
            PlayerPrefs.SetFloat("BlueReproCount", newBlueCount_2);
        }
        Debug.Log("b-NNN " + addedBlue);

    }

    void ReproRed()
    {
        newRedCount = PlayerPrefs.GetFloat("RedCount");
        reproRed = PlayerPrefs.GetFloat("ReproRed");
        Debug.Log("r-RRR " + reproRed);
        Debug.Log("r-OOO " + newRedCount);

        if (reproChanceRed <= reproRed)
        {
            Debug.Log(reproChanceRed + ":::" + reproRed);
            reproProcentRed = reproRed / 10;

            newRedCount_1 = newRedCount * reproProcentRed;
            newRedCount_2 = Mathf.Round(newRedCount_1);
            for (int i = 0; i < newRedCount_2; i++)
            {
                GameObject red = Instantiate(Red);
                red.transform.localPosition = new Vector3(8, 0.12f, Random.Range(-4, 4));
              
            }
            addedRed = newRedCount + newRedCount_2;
            PlayerPrefs.SetFloat("RedCount", addedRed);
            PlayerPrefs.SetFloat("RedReproCount", newRedCount_2);
        }
        Debug.Log("r-NNN " + addedRed);
    }
}