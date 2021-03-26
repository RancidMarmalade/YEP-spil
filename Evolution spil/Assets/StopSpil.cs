using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopSpil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StopTimer());
    }
    IEnumerator StopTimer() {
        yield return new WaitForSecondsRealtime(10);
        SceneManager.LoadScene(3);
    }
}
