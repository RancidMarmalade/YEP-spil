using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class graf : MonoBehaviour
{
    public Image blue0;
    public Image red0;
    public Image blue1;
    public Image red1;
    public Image blue2;
    public Image red2;
    public Image blue3;
    public Image red3;
    public Image blue4;
    public Image red4;
    public Image blue5;
    public Image red5;
    public Image blue6;
    public Image red6;
    public Image blue7;
    public Image red7;
    public Image blue8;
    public Image red8;
    public Image blue9;
    public Image red9;
    public Image blue10;
    public Image red10;
    // Start is called before the first frame update
    void Start()
    {
        float b0 = PlayerPrefs.GetFloat("Blue0") * 10;
        float r0 = PlayerPrefs.GetFloat("Red0") * 10;
        blue0.rectTransform.sizeDelta = new Vector2(25, b0);
        red0.rectTransform.sizeDelta = new Vector2(25, r0);

        float b1 = PlayerPrefs.GetFloat("Blue1") * 10;
        float r1 = PlayerPrefs.GetFloat("Red1") * 10;
        blue1.rectTransform.sizeDelta = new Vector2(25, b1);
        red1.rectTransform.sizeDelta = new Vector2(25, r1);

        float b2 = PlayerPrefs.GetFloat("Blue2") * 10;
        float r2 = PlayerPrefs.GetFloat("Red2") * 10;
        blue2.rectTransform.sizeDelta = new Vector2(25, b2);
        red2.rectTransform.sizeDelta = new Vector2(25, r2);

        float b3 = PlayerPrefs.GetFloat("Blue3") * 10;
        float r3 = PlayerPrefs.GetFloat("Red3") * 10;
        blue3.rectTransform.sizeDelta = new Vector2(25, b3);
        red3.rectTransform.sizeDelta = new Vector2(25, r3);

        float b4 = PlayerPrefs.GetFloat("Blue4") * 10;
        float r4 = PlayerPrefs.GetFloat("Red4") * 10;
        blue4.rectTransform.sizeDelta = new Vector2(25, b4);
        red4.rectTransform.sizeDelta = new Vector2(25, r4);

        float b5 = PlayerPrefs.GetFloat("Blue5") * 10;
        float r5 = PlayerPrefs.GetFloat("Red5") * 10;
        blue5.rectTransform.sizeDelta = new Vector2(25, b5);
        red5.rectTransform.sizeDelta = new Vector2(25, r5);

        float b6 = PlayerPrefs.GetFloat("Blue6") * 10;
        float r6 = PlayerPrefs.GetFloat("Red6") * 10;
        blue6.rectTransform.sizeDelta = new Vector2(25, b6);
        red6.rectTransform.sizeDelta = new Vector2(25, r6);

        float b7 = PlayerPrefs.GetFloat("Blue7") * 10;
        float r7 = PlayerPrefs.GetFloat("Red7") * 10;
        blue7.rectTransform.sizeDelta = new Vector2(25, b7);
        red7.rectTransform.sizeDelta = new Vector2(25, r7);

        float b8 = PlayerPrefs.GetFloat("Blue8") * 10;
        float r8 = PlayerPrefs.GetFloat("Red8") * 10;
        blue8.rectTransform.sizeDelta = new Vector2(25, b8);
        red8.rectTransform.sizeDelta = new Vector2(25, r8);

        float b9 = PlayerPrefs.GetFloat("Blue9") * 10;
        float r9 = PlayerPrefs.GetFloat("Red9") * 10;
        blue9.rectTransform.sizeDelta = new Vector2(25, b9);
        red9.rectTransform.sizeDelta = new Vector2(25, r9);

        float b10 = PlayerPrefs.GetFloat("Blue10") * 10;
        float r10 = PlayerPrefs.GetFloat("Red10") * 10;
        blue10.rectTransform.sizeDelta = new Vector2(25, b10);
        red10.rectTransform.sizeDelta = new Vector2(25, r10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
