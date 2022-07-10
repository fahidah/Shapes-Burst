using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // variable declaration
    public GameObject[] shapes;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnShapees", 2f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnShapes()
    {
        Instantiate(shapes[Random.Range(0, shapes.Length)]);
    }
}
