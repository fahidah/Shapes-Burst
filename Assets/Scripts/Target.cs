using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody shapesRB;
    private float xMinRange = -2.8f;
    private float xMaxRange = 1.3f;
    private float ySpawnPos = 4;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 5;

    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GameStart()
    {
        shapesRB = GetComponent<Rigidbody>();
        shapesRB.AddForce(RandomForce(), ForceMode.Impulse);
        shapesRB.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPosition();
    }

    Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(xMinRange, xMaxRange), ySpawnPos);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
}
