using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class graf : MonoBehaviour
{
    public GameObject Graf;
    public GameObject Blue;
    public GameObject Red;
    public GameObject Count;

    private Text bT;
    private Text rT;
    // Start is called before the first frame update
    void Start()
    {
        float Divider = 0;
        float b0o = 0;
        float r0o = 0;
        float scale = 1;
        for (int j = 0; j < 11; j++)
        {
            string b = "Blue" + j.ToString();
            string r = "Red" + j.ToString();
            float b0 = PlayerPrefs.GetFloat(b) * 10;
            if (b0 > b0o)
            {
                b0o = b0;
            }
            float r0 = PlayerPrefs.GetFloat(r) * 10;
            if (r0 > r0o)
            {
                r0o = r0;
            }
        }
        if (b0o >= 91000 || r0o >= 91000)
        {
            Divider = 1000;
            scale = 1000;
        }
        else if (b0o >= 9100 || r0o >= 9100)
        {
            Divider = 100;
            scale = 100;
        }
        else if (b0o >= 910 || r0o >= 910)
        {
            Divider = 10;
            scale = 10;
        }
        else if (b0o >= 91 || r0o >= 91)
        {
            Divider = 1;
            scale = 1;
        }
        else
        {
            Divider = 0.1f;
            scale = 0.1f;
        }

        float x = 50;
        float startPos = (11 * 120 / 2 + 10) * -1;
        for (int i = 0; i < 11; i++)
        {
            var blue = Instantiate(Blue) as GameObject;
            blue.transform.SetParent(Graf.transform, false);
            var red = Instantiate(Red) as GameObject;
            red.transform.SetParent(Graf.transform, false);
            string b = "Blue" + i.ToString();
            string r = "Red" + i.ToString();
            float b0 = PlayerPrefs.GetFloat(b);
            Debug.Log("b0|1: " + b0);
            float r0 = PlayerPrefs.GetFloat(r);
            float b0n = (b0 * 10) / Divider;
            float r0n = (r0 * 10) / Divider;
            float b0x = startPos + (120 * (i + 1));
            float b0y = -440 + (b0n / 2);
            float r0y = -440 + (r0n / 2);
            blue.transform.localPosition = new Vector2(b0x, b0y);
            red.transform.localPosition = new Vector2(b0x - x, r0y);
            blue.GetComponent<RectTransform>().sizeDelta = new Vector2(x, b0n);
            red.GetComponent<RectTransform>().sizeDelta = new Vector2(x, r0n);
            var textb = Instantiate(Count) as GameObject;
            textb.transform.SetParent(blue.transform, false);
            bT = textb.GetComponent<Text>();
            bT.text = "" + b0;
            var textr = Instantiate(Count) as GameObject;
            textr.transform.SetParent(red.transform, false);
            rT = textr.GetComponent<Text>();
            rT.text = "" + r0;
        }
    }
}
