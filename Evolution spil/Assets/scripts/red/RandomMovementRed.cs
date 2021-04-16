using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovementRed : MonoBehaviour
{
    public GameObject DeathParticleRed;
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
        Destination = new Vector3(Random.Range(-8, 8), 0.12f, Random.Range(-4, 4));
        Speed = PlayerPrefs.GetInt("SpeedRed");
        Agression = PlayerPrefs.GetInt("AgresRed");
        EnemyAgression = PlayerPrefs.GetInt("AgresBlue");
        Life = PlayerPrefs.GetFloat("Life");
    }
    void FixedUpdate()
    {
        Rb.drag = Rb.velocity.magnitude / 2;
        transform.LookAt(Destination);
        Rb.AddRelativeForce(0, 0, Speed);
        if (Vector3.Distance(transform.position, Destination) <= 1)
        {
            Destination = new Vector3(Random.Range(-8, 8), 0.12f, Random.Range(-4, 4));
        }

        if (Life < 0.5f)
        {
            count = PlayerPrefs.GetFloat("RedCount");
            newCount = count - 1;
            PlayerPrefs.SetFloat("RedCount", newCount);
            Instantiate(DeathParticleRed,transform.position,transform.rotation);
            //Debug.Log("Red Count" + newCount);
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Blue"))
        {
            Life = Life - Life * EnemyAgression / 10;
            //Debug.Log("Red: " + Life);
            return;
        }
    }
}
