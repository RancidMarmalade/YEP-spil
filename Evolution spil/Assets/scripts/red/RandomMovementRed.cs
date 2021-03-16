using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovementRed : MonoBehaviour
{
    public Rigidbody Rb;
    public Vector3 Destination;
    public float Distance;

    private int Speed;
    public int Agression;
    public float Life;

    public int EnemyAgression;

    private int count;
    private int newCount;

    public void Awake()
    {
        Destination = new Vector3(Random.Range(-8, 8), 0, Random.Range(-4, 4));
        Speed = PlayerPrefs.GetInt("SpeedRed");
        Agression = PlayerPrefs.GetInt("AgresRed");
        EnemyAgression = PlayerPrefs.GetInt("AgresBlue");
        Life = PlayerPrefs.GetFloat("Life");
        Debug.Log("Red stats: Speed:" + Speed + ", Agression:" + Agression + ", Life:" + Life);
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
            count = PlayerPrefs.GetInt("RedCount");
            newCount = count - 1;
            PlayerPrefs.SetInt("RedCount", newCount);
            Debug.Log("Red Count" + newCount);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Blue"))
        {
            Life = Life - Life * EnemyAgression / 10;
            Debug.Log("Red: " + Life);
            return;
        }
    }
}
