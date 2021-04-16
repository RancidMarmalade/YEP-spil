using System.Collections;
using UnityEngine;

public class selfDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Die());
    }
    IEnumerator Die() {
        yield return new WaitForSecondsRealtime(1);
        Destroy(gameObject);
    }
}
