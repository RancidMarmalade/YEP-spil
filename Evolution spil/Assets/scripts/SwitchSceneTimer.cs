using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneTimer : MonoBehaviour
{

    [SerializeField]
    private int sceneIndex;

    [SerializeField]
    private int TIME_LIMIT;

    private float timer = 0F;

    void Update()
    {
        this.timer += Time.deltaTime;

        if (this.timer >= TIME_LIMIT)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
