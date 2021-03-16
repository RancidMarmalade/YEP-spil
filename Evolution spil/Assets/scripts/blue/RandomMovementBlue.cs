using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovementBlue : MonoBehaviour
{
    public Rigidbody Rb;
    public Vector3 Destination;
    public float Distance;

    private int Speed;
    public int Agression;
    public float Life;

    public int EnemyAgression;


    private float count;
    private float newCount;

    public void Awake()
    {
        Destination = new Vector3(Random.Range(-8, 8), 0, Random.Range(-4, 4));
        Speed = PlayerPrefs.GetInt("SpeedBlue");
        Agression = PlayerPrefs.GetInt("AgresBlue");
        EnemyAgression = PlayerPrefs.GetInt("AgresRed");
        Life = PlayerPrefs.GetFloat("Life");
        Debug.Log("Blue stats: Speed:" + Speed + ", Agression:" + Agression + ", Life:" + Life);
        count = PlayerPrefs.GetFloat("BlueCount");
    }

    void FixedUpdate()
    {
        Rb.drag = Rb.velocity.magnitude / 2;
        transform.LookAt(Destination);
        Rb.AddRelativeForce(0, 0, Speed);
        if (Vector3.Distance(transform.position, Destination) <= 1)
        {
            Destination = new Vector3(Random.Range(-8, 8), 0, Random.Range(-4, 4));
        }

        if (Life < 0.5f)
        {
            count = PlayerPrefs.GetFloat("BlueCount");
            newCount = count - 1;
            PlayerPrefs.SetFloat("BlueCount", newCount);
            //Debug.Log("Blue Count" + newCount);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Red"))
        {
            Life = Life - Life * EnemyAgression / 10;
            //Debug.Log("Blue: " + Life);
            return;
        }
    }
}
