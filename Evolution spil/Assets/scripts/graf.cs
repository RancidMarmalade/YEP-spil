using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class graf : MonoBehaviour
{
    public Image blue1;
    public Image red1;
    public float blueOne;
    // Start is called before the first frame update
    void Start()
    {
        blueOne = PlayerPrefs.GetFloat("Blue1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
