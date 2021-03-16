using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantieter : MonoBehaviour
{
    public GameObject Blue;
    public GameObject Red;

    public int blueCount = 10;
    public int redCount = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < blueCount; i++)
        {
            GameObject blue = Instantiate(Blue);
            blue.transform.localPosition = new Vector3(-8, 0.088f, Random.Range(-4, 4));
            PlayerPrefs.SetInt("BlueCount", blueCount);
        }

        for (int i = 0; i < redCount; i++)
        {
            GameObject red = Instantiate(Red);
            red.transform.localPosition = new Vector3(8, 0, Random.Range(-4, 4));
            PlayerPrefs.SetInt("RedCount", redCount);
        }

    }
}
